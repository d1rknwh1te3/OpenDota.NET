namespace OpenDotaDotNet.Routes.Matches.Models;

public class WardLog
{
	[JsonProperty("attackername")]
	public string AttackerName { get; set; }

	[JsonProperty("ehandle")]
	public long Ehandle { get; set; }

	[JsonProperty("entityleft")]
	public bool EntityLeft { get; set; }

	[JsonProperty("key")]
	public string Key { get; set; }

	[JsonProperty("player_slot")]
	public int PlayerSlot { get; set; }

	[JsonProperty("slot")]
	public int Slot { get; set; }

	[JsonProperty("time")]
	public int Time { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("x")]
	public long X { get; set; }

	[JsonProperty("y")]
	public long Y { get; set; }

	[JsonProperty("z")]
	public long Z { get; set; }
}