namespace OpenDotaDotNet.Routes.HeroStats.Enums;

/// <summary>
/// The primary attribute of the hero.
/// </summary>
public enum HeroPrimaryAttribute
{
	/// <summary>
	/// Agility attribute.
	/// </summary>
	[JsonProperty("agi")] Agility = 0,

	/// <summary>
	/// Intelligence attribute.
	/// </summary>
	[JsonProperty("int")] Intelligence = 1,

	/// <summary>
	/// Strength attribute.
	/// </summary>
	[JsonProperty("str")] Strength = 2,

	/// <summary>
	/// Universal attribute.
	/// </summary>
	[JsonProperty("all")] All = 3,
}