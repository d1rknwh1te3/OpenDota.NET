namespace OpenDotaDotNet.Converters;

/// <inheritdoc/>
public class StringToIntNull : JsonConverter<int?>
{
	/// <inheritdoc/>
	public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			var value = reader.GetString();

			return int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result)
				? result
				: null;
		}

		return reader.TokenType == JsonTokenType.Number
			? reader.GetInt32()
			: null;
	}

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
	{
		if (value != null)
			writer.WriteNumberValue((int)value);
		else
			writer.WriteNullValue();
	}
}