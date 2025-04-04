﻿namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player wins and losses.
/// </summary>
public class PlayerWinLoss
{
	/// <summary>
	/// Gets the wins.
	/// </summary>
	[JsonPropertyName("win")]
	public int Wins { get; init; }

	/// <summary>
	/// Gets the losses.
	/// </summary>
	[JsonPropertyName("lose")]
	public int Losses { get; init; }
}