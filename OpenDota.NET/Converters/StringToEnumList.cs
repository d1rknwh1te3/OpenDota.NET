namespace OpenDotaDotNet.Converters;

/// <inheritdoc />
public class StringToEnumList<T> : JsonConverter<List<T>> where T : struct, Enum
{
	/// <inheritdoc />
	public override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartArray)
			throw new JsonException($"Expected StartArray token but got {reader.TokenType}.");

		var list = new List<T>();

		while (reader.Read())
		{
			if (reader.TokenType == JsonTokenType.EndArray)
				return list;

			if (reader.TokenType == JsonTokenType.String)
			{
				var jsonValue = reader.GetString();

				foreach (var member in typeof(T).GetMembers(BindingFlags.Public | BindingFlags.Static))
				{
					var jsonPropertyNameAttr = member.GetCustomAttribute<JsonPropertyNameAttribute>();

					if (jsonPropertyNameAttr == null || !jsonPropertyNameAttr.Name.Equals(jsonValue, StringComparison.OrdinalIgnoreCase)) 
						continue;

					if (!Enum.TryParse(typeof(T), member.Name, true, out var result)) 
						continue;

					list.Add((T)result);
					break;
				}

				if (Enum.TryParse(jsonValue, true, out T parsedResult))
				{
					list.Add(parsedResult);
				}
				else
				{
					throw new JsonException($"Unable to convert '{jsonValue}' to {typeof(T).Name}.");
				}
			}
			else if (reader.TokenType == JsonTokenType.Number)
			{
				if (reader.TryGetInt32(out var intValue) && Enum.IsDefined(typeof(T), intValue))
				{
					list.Add((T)Enum.ToObject(typeof(T), intValue));
				}
				else
				{
					throw new JsonException($"Unable to convert number '{intValue}' to {typeof(T).Name}.");
				}
			}
			else
			{
				throw new JsonException($"Unexpected token type '{reader.TokenType}' when deserializing {typeof(T).Name}.");
			}
		}

		throw new JsonException("Unexpected end of JSON array.");
	}

	/// <inheritdoc />
	public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
	{
		writer.WriteStartArray();
		foreach (var item in value)
		{
			writer.WriteStringValue(item.ToString());
		}
		writer.WriteEndArray();
	}
}
