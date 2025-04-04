namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents match data.
/// </summary>
public class Data
{
	/// <summary>
	/// Gets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; init; }

	/// <summary>
	/// Gets whether the radiant team won.
	/// </summary>
	[JsonPropertyName("radiant_win")]
	public bool RadiantWin { get; init; }

	/// <summary>
	/// Gets Unix timestamp of when the match began.
	/// </summary>
	[JsonPropertyName("start_time")]
	public long StartTime { get; init; }

	/// <summary>
	/// Gets length of the match.
	/// </summary>
	[JsonPropertyName("duration")]
	public int Duration { get; init; }

	/// <summary>
	/// Gets the player group.
	/// </summary>
	[JsonPropertyName("pgroup")]
	public Dictionary<string, Pgroup> Pgroup { get; init; } = new();

	/// <summary>
	/// Gets the player's ability upgrades.
	/// </summary>
	[JsonPropertyName("ability_upgrades")]
	public List<object> AbilityUpgrades { get; init; } = new();
}