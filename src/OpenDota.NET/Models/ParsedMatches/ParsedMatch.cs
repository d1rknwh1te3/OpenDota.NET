namespace OpenDotaDotNet.Models.ParsedMatches;

/// <summary>
/// Represents a parsed match.
/// </summary>
public class ParsedMatch
{
	[JsonProperty("match_id")]
	public long MatchId { get; set; }
}