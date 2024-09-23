namespace OpenDotaDotNet.Routes.ParsedMatches.Models;

/// <summary>
/// Represents a parsed match.
/// </summary>
public class ParsedMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }
}