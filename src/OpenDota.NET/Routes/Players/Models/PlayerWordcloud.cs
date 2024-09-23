﻿namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player wordcloud.
/// </summary>
public class PlayerWordCloud
{
	[JsonProperty("my_word_counts")]
	public Dictionary<string, long> MyWordCounts { get; set; }

	[JsonProperty("all_word_counts")]
	public Dictionary<string, long> AllWordCounts { get; set; }
}