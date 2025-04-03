namespace OpenDotaDotNet.Routes.PublicMatches.Models;

/// <summary>
/// Represents a public match.
/// </summary>
public class PublicMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	[JsonPropertyName("match_seq_num")]
	public long MatchSeqNum { get; set; }

	[JsonPropertyName("radiant_win")]
	public bool RadiantWin { get; set; }

	[JsonPropertyName("start_time")]
	public long StartTime { get; set; }

	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Gets or sets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonPropertyName("lobby_type")]
	public int LobbyType { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonPropertyName("game_mode")]
	public int GameMode { get; set; }

	[JsonPropertyName("avg_rank_tier")]
	public int AvgRankTier { get; set; }

	[JsonPropertyName("num_rank_tier")]
	public int NumRankTier { get; set; }

	[JsonPropertyName("cluster")]
	public int Cluster { get; set; }

	[JsonPropertyName("radiant_team")]
	public int[] RadiantTeam { get; set; }

	[JsonPropertyName("dire_team")]
	public int[] DireTeam { get; set; }
}