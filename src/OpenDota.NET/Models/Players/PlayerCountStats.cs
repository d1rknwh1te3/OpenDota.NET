namespace OpenDotaDotNet.Models.Players;

public class PlayerCountStats
{
	[JsonProperty("games")]
	public long Games { get; set; }

	[JsonProperty("win")]
	public long Win { get; set; }
}