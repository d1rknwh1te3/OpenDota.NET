namespace OpenDotaDotNet.Routes.FindMatches.Models;

/// <summary>
/// Represents a single match.
/// </summary>
public class FindMatch
{
	/// <summary>
	/// Gets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; init; }

	/// <summary>
	/// Gets the array of hero IDs on first team.
	/// </summary>
	[JsonPropertyName("teama")]
	public List<int> TeamA { get; init; } = [];

	/// <summary>
	/// Gets the array of hero IDs on second team.
	/// </summary>
	[JsonPropertyName("teamb")]
	public List<int> TeamB { get; init; } = [];

	/// <summary>
	/// Gets whether the first team won.
	/// </summary>
	[JsonPropertyName("teamawin")]
	public bool TeamAWin { get; init; }

	/// <summary>
	/// Gets the time the match started.
	/// </summary>
	[JsonPropertyName("start_time")]
	public long StartTime { get; init; }
}