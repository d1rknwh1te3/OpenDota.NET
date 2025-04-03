﻿namespace OpenDotaDotNet.Routes.HeroStats.Enums;

/// <summary>
/// The primary attribute of the hero.
/// </summary>
public enum HeroPrimaryAttribute
{
	/// <summary>
	/// Agility attribute.
	/// </summary>
	[JsonPropertyName("agi")] Agility = 0,

	/// <summary>
	/// Intelligence attribute.
	/// </summary>
	[JsonPropertyName("int")] Intelligence = 1,

	/// <summary>
	/// Strength attribute.
	/// </summary>
	[JsonPropertyName("str")] Strength = 2,

	/// <summary>
	/// Universal attribute.
	/// </summary>
	[JsonPropertyName("all")] All = 3,
}