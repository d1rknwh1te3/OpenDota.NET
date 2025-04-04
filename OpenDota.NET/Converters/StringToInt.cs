namespace OpenDotaDotNet.Converters;

/// <inheritdoc/>
public class StringToInt : JsonConverter<int>
{
	/// <inheritdoc/>
	public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			var value = reader.GetString();

			return int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result)
				? result
				: int.MinValue;
		}

		return reader.TokenType == JsonTokenType.Number
			? reader.GetInt32()
			: int.MinValue;
	}

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
	{
		writer.WriteNumberValue(value);
	}
}