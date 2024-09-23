namespace OpenDotaDotNet.Routes.Request.Models;

public class Data
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("radiant_win")]
	public bool RadiantWin { get; set; }

	/// <summary>
	/// Gets or sets Unix timestamp of when the match began.
	/// </summary>
	[JsonProperty("start_time")]
	public long StartTime { get; set; }

	/// <summary>
	/// Gets or sets length of the match.
	/// </summary>
	[JsonProperty("duration")]
	public int Duration { get; set; }

	[JsonProperty("pgroup")]
	public Dictionary<string, Pgroup> Pgroup { get; set; }

	[JsonProperty("ability_upgrades")]
	public IEnumerable<object> AbilityUpgrades { get; set; }
}