namespace OpenDotaDotNet.Routes.Matches.Models;

public class WardLog
{
	[JsonPropertyName("attackername")]
	public string AttackerName { get; set; }

	[JsonPropertyName("ehandle")]
	public long Ehandle { get; set; }

	[JsonPropertyName("entityleft")]
	public bool EntityLeft { get; set; }

	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public int PlayerSlot { get; set; }

	[JsonPropertyName("slot")]
	public int Slot { get; set; }

	[JsonPropertyName("time")]
	public int Time { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("x")]
	public long X { get; set; }

	[JsonPropertyName("y")]
	public long Y { get; set; }

	[JsonPropertyName("z")]
	public long Z { get; set; }
}