namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerWinLoss
{
	[JsonProperty("win")]
	public int Wins { get; set; }

	[JsonProperty("lose")]
	public int Losses { get; set; }
}