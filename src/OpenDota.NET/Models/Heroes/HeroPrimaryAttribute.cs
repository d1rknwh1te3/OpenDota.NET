namespace OpenDotaDotNet.Models.Heroes;

/// <summary>
/// The primary attribute of the hero.
/// </summary>
public enum HeroPrimaryAttribute
{
	/// <summary>
	/// Agility attribute.
	/// </summary>
	[JsonProperty("agi")] Agi = 0,

	/// <summary>
	/// Intelligence attribute.
	/// </summary>
	[JsonProperty("int")] Int = 1,

	/// <summary>
	/// Strength attribute.
	/// </summary>
	[JsonProperty("str")] Str = 2,

	/// <summary>
	/// Universal attribute.
	/// </summary>
	[JsonProperty("all")] All = 3,
}