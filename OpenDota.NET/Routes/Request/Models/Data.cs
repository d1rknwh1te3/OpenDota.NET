namespace OpenDotaDotNet.Routes.Request.Models;

public class Data
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	[JsonPropertyName("radiant_win")]
	public bool RadiantWin { get; set; }

	/// <summary>
	/// Gets or sets Unix timestamp of when the match began.
	/// </summary>
	[JsonPropertyName("start_time")]
	public long StartTime { get; set; }

	/// <summary>
	/// Gets or sets length of the match.
	/// </summary>
	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	[JsonPropertyName("pgroup")]
	public Dictionary<string, Pgroup> Pgroup { get; set; }

	[JsonPropertyName("ability_upgrades")]
	public IEnumerable<object> AbilityUpgrades { get; set; }
}