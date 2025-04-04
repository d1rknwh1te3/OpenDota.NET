namespace OpenDotaDotNet.Converters;

/// <inheritdoc/>
public class StringToDouble : JsonConverter<double>
{
	/// <inheritdoc/>
	public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			var value = reader.GetString();

			return double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var result)
				? result
				: double.NaN;
		}

		return reader.TokenType == JsonTokenType.Number 
			? reader.GetDouble() 
			: double.NaN;
	}

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
	{
		writer.WriteNumberValue(value);
	}
}