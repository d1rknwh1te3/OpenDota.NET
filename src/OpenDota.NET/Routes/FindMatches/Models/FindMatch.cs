namespace OpenDotaDotNet.Routes.FindMatches.Models;

/// <summary>
/// Represents a single match.
/// </summary>
public class FindMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	/// <summary>
	/// Gets or sets the array of hero IDs on first team.
	/// </summary>
	[JsonProperty("teama")]
	public IEnumerable<int> TeamA { get; set; }

	/// <summary>
	/// Gets or sets the array of hero IDs on second team.
	/// </summary>
	[JsonProperty("teamb")]
	public IEnumerable<int> TeamB { get; set; }

	[JsonProperty("teamawin")]
	public bool TeamAWin { get; set; }

	[JsonProperty("start_time")]
	public long StartTime { get; set; }
}