namespace OpenDotaDotNet.Routes.Teams.Models;

/// <summary>
/// Represents a team match.
/// </summary>
public class TeamMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("radiant_win")]
	public bool RadiantWin { get; set; }

	[JsonProperty("radiant")]
	public bool Radiant { get; set; }

	[JsonProperty("duration")]
	public long Duration { get; set; }

	[JsonProperty("start_time")]
	public long StartTime { get; set; }

	[JsonProperty("leagueid")]
	public long Leagueid { get; set; }

	[JsonProperty("league_name")]
	public string LeagueName { get; set; }

	[JsonProperty("cluster")]
	public long Cluster { get; set; }

	[JsonProperty("opposing_team_id")]
	public long OpposingTeamId { get; set; }

	[JsonProperty("opposing_team_name")]
	public string OpposingTeamName { get; set; }

	[JsonProperty("opposing_team_logo")]
	public Uri OpposingTeamLogo { get; set; }
}