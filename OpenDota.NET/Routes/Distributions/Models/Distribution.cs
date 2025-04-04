﻿namespace OpenDotaDotNet.Routes.Distributions.Models;

/// <summary>
/// Represents a distribution.
/// </summary>
public class Distribution
{
	/// <summary>
	/// Gets the ranks.
	/// </summary>
	[JsonPropertyName("ranks")]
	public Ranks Ranks { get; init; } = new();
}