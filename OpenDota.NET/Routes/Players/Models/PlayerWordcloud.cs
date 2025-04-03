namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player wordcloud.
/// </summary>
public class PlayerWordCloud
{
	[JsonPropertyName("my_word_counts")]
	public Dictionary<string, long> MyWordCounts { get; set; }

	[JsonPropertyName("all_word_counts")]
	public Dictionary<string, long> AllWordCounts { get; set; }
}