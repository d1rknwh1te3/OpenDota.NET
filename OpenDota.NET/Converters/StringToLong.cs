namespace OpenDotaDotNet.Converters;

/// <inheritdoc/>
public class StringToLong : JsonConverter<long>
{
	/// <inheritdoc/>
	public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			var value = reader.GetString();

			return int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result)
				? result
				: long.MinValue;
		}

		return reader.TokenType == JsonTokenType.Number
			? reader.GetInt64()
			: long.MinValue;
	}

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
	{
		writer.WriteNumberValue(value);
	}
}