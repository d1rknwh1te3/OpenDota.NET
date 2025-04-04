﻿namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a max hero hit.
/// </summary>
public class MaxHeroHit
{
	/// <summary>
	/// Gets a always -> max_hero_hit
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; } = string.Empty;

	/// <summary>
	/// Gets a time (in seconds) when the hit occurred
	/// </summary>
	[JsonPropertyName("time")]
	public int Time { get; init; }

	/// <summary>
	/// Gets whether it was a max hero hit (should be true)
	/// </summary>
	[JsonPropertyName("max")]
	public bool Max { get; init; }

	/// <summary>
	/// Gets the inflictor of the hit
	/// </summary>
	[JsonPropertyName("inflictor")]
	public string Inflictor { get; init; } = string.Empty;

	/// <summary>
	/// Gets the unit which inflicted the hit
	/// </summary>
	[JsonPropertyName("unit")]
	public string Unit { get; init; } = string.Empty;

	/// <summary>
	/// Gets the unit to which it was inflicted
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; init; } = string.Empty;

	/// <summary>
	/// Gets a damage inflicted
	/// </summary>
	[JsonPropertyName("value")]
	public long Value { get; init; }

	/// <summary>
	/// Gets a slot
	/// </summary>
	[JsonPropertyName("slot")]
	public long Slot { get; init; }

	/// <summary>
	/// Gets a slot of player
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; init; }
}