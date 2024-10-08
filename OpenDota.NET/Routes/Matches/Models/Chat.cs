﻿namespace OpenDotaDotNet.Routes.Matches.Models;

public class Chat
{
	// Time in seconds at which the message was said
	[JsonProperty("time")]
	public int Time { get; set; }

	// Type of message [currently known values - "chat" and "chatwheel"]
	[JsonProperty("type")]
	public string Type { get; set; }

	// The message the player sent
	[JsonProperty("key")]
	public string Key { get; set; }

	// The slot of the player
	[JsonProperty("slot")]
	public long Slot { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonProperty("player_slot")]
	public long PlayerSlot { get; set; }

	// Name of the player who sent the message
	[JsonProperty("unit")]
	public string Unit { get; set; }
}