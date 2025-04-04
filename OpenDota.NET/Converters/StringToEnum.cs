namespace OpenDotaDotNet.Converters;

/// <inheritdoc />
public class StringToEnum<T> : JsonConverter<T> where T : struct, Enum
{
	/// <inheritdoc />
	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			var jsonValue = reader.GetString();

			foreach (var member in typeToConvert.GetMembers(BindingFlags.Public | BindingFlags.Static))
			{
				var jsonPropertyNameAttr = member.GetCustomAttribute<JsonPropertyNameAttribute>();
				
				if (jsonPropertyNameAttr == null || !jsonPropertyNameAttr.Name.Equals(jsonValue, StringComparison.OrdinalIgnoreCase)) 
					continue;

				if (Enum.TryParse(typeToConvert, member.Name, true, out var result))
					return (T)result;
			}

			if (Enum.TryParse(typeToConvert, jsonValue, true, out var parsedResult))
				return (T)parsedResult;

			throw new JsonException($"Unable to convert '{jsonValue}' to {typeToConvert.Name}.");
		}

		if (reader.TokenType == JsonTokenType.Number)
		{
			if (reader.TryGetInt32(out var intValue) && Enum.IsDefined(typeToConvert, intValue))
				return (T)Enum.ToObject(typeToConvert, intValue);

			throw new JsonException($"Unable to convert number '{intValue}' to {typeToConvert.Name}.");
		}

		throw new JsonException($"Unexpected token type '{reader.TokenType}' when deserializing {typeToConvert.Name}.");
	}

	/// <inheritdoc />
	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToString());
	}
}