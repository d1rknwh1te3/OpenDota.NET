namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerCountStats
{
	[JsonProperty("games")]
	public long Games { get; set; }

	[JsonProperty("win")]
	public long Win { get; set; }
}