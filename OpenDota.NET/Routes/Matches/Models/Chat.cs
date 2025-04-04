﻿namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a chat
/// </summary>
public class Chat
{
	/// <summary>
	/// Gets time in seconds at which the message was said
	/// </summary>
	[JsonPropertyName("time")]
	public int Time { get; init; }

	/// <summary>
	/// Gets type of message [currently known values - "chat" and "chatwheel"]
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; } = string.Empty;

	/// <summary>
	/// Gets the message the player sent
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; init; } = string.Empty;

	/// <summary>
	/// Gets the slot of the player
	/// </summary>
	[JsonPropertyName("slot")]
	public long Slot { get; init; }

	/// <summary>
	/// Gets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long PlayerSlot { get; init; }

	// Gets name of the player who sent the message
	[JsonPropertyName("unit")]
	public string Unit { get; init; } = string.Empty;
}