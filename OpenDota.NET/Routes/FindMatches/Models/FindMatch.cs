namespace OpenDotaDotNet.Routes.FindMatches.Models;

/// <summary>
/// Represents a single match.
/// </summary>
public class FindMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	/// <summary>
	/// Gets or sets the array of hero IDs on first team.
	/// </summary>
	[JsonPropertyName("teama")]
	public IEnumerable<int> TeamA { get; set; }

	/// <summary>
	/// Gets or sets the array of hero IDs on second team.
	/// </summary>
	[JsonPropertyName("teamb")]
	public IEnumerable<int> TeamB { get; set; }

	[JsonPropertyName("teamawin")]
	public bool TeamAWin { get; set; }

	[JsonPropertyName("start_time")]
	public long StartTime { get; set; }
}