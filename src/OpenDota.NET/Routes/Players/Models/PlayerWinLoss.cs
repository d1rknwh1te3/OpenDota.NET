namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player wins and losses.
/// </summary>
public class PlayerWinLoss
{
	/// <summary>
	/// Gets or sets the wins.
	/// </summary>
	[JsonProperty("win")]
	public int Wins { get; set; }

	/// <summary>
	/// Gets or sets the losses.
	/// </summary>
	[JsonProperty("lose")]
	public int Losses { get; set; }
}