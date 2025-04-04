namespace OpenDotaDotNet;

/// <summary>
/// Represents the OpenDota.NET settings.
/// </summary>
public class OpenDotaSettings
{
	/// <summary>
	/// The OpenDota API key.
	/// </summary>
	public string? ApiKey { get; set; } = null;

	/// <summary>
	/// The proxy.
	/// </summary>
	public IWebProxy? Proxy { get; set; } = null;

	/// <summary>
	/// The JSON serializer options. If you want to use own options, set this property.
	/// </summary>
	public JsonSerializerOptions? JsonSerializerOptions { get; set; } = new(JsonSerializerOptions.Web)
	{
		Converters =
		{
			new StringToBooleanNull(), new StringToDoubleNull(), new StringToIntNull(), new StringToLongNull(),
			new StringToDouble(), new StringToInt(), new StringToLong(),
			new StringToEnumList<HeroRole>(),
			new StringToEnum<HeroPrimaryAttribute>(), new StringToEnum<HeroAttackType>(), 
			new StringToEnum<Tier>(), new StringToEnum<LaneRole>(), new StringToEnum<Scenario>()
		},
		IncludeFields = true,
	};
}