namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player wins and losses.
/// </summary>
public class PlayerWinLoss
{
	/// <summary>
	/// Gets or sets the wins.
	/// </summary>
	[JsonPropertyName("win")]
	public int Wins { get; set; }

	/// <summary>
	/// Gets or sets the losses.
	/// </summary>
	[JsonPropertyName("lose")]
	public int Losses { get; set; }
}