using OpenDotaDotNet.Routes.HeroStats.Enums;

namespace OpenDotaDotNet.Routes.Heroes.Models;

/// <summary>
/// Represents a hero.
/// </summary>
public class Hero
{
	/// <summary>
	/// Gets or sets numeric identifier for the hero object.
	/// </summary>
	[JsonProperty("id")]
	public required long Id { get; set; }

	/// <summary>
	/// Gets or sets dota hero command name, e.g. 'npc_dota_hero_antimage'.
	/// </summary>
	[JsonProperty("name")]
	public required string Name { get; set; }

	/// <summary>
	/// Gets or sets hero name, e.g. 'Anti-Mage'.
	/// </summary>
	[JsonProperty("localized_name")]
	public required string LocalizedName { get; set; }

	/// <summary>
	/// Gets or sets hero primary shorthand attribute name, e.g. 'agi'.
	/// </summary>
	[JsonProperty("primary_attr")]
	public required HeroPrimaryAttribute PrimaryAttribute { get; set; }

	/// <summary>
	/// Gets or sets hero attack type, either 'Melee' or 'Ranged'.
	/// </summary>
	[JsonProperty("attack_type")]
	public required HeroAttackType HeroAttackType { get; set; }

	/// <summary>
	/// Gets or sets hero's role in the game.
	/// </summary>
	[JsonProperty("roles")]
	public required IEnumerable<HeroRole> Roles { get; set; }

	/// <summary>
	/// Gets or sets hero's amount of legs.
	/// </summary>
	[JsonProperty("legs")]
	public required int Legs { get; set; }
}