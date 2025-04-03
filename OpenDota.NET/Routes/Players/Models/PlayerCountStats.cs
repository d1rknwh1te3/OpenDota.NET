namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerCountStats
{
	[JsonPropertyName("games")]
	public long Games { get; set; }

	[JsonPropertyName("win")]
	public long Win { get; set; }
}