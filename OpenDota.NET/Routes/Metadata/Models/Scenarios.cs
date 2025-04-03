﻿namespace OpenDotaDotNet.Routes.Metadata.Models;

/// <summary>
/// Represents the scenarios.
/// </summary>
public class Scenarios
{
	/// <summary>
	/// Gets or sets the item cost.
	/// </summary>
	[JsonPropertyName("itemCost")]
	public int ItemCost { get; set; }

	/// <summary>
	/// Gets or sets the timings.
	/// </summary>
	[JsonPropertyName("timings")]
	public int[] Timings { get; set; }

	/// <summary>
	/// Gets or sets the game duration bucket.
	/// </summary>
	[JsonPropertyName("gameDurationBucket")]
	public int[] GameDurationBucket { get; set; }

	/// <summary>
	/// Gets or sets the team scenarios query parameters.
	/// </summary>
	[JsonPropertyName("teamScenariosQueryParams")]
	public string[] TeamScenariosQueryParams { get; set; }
}