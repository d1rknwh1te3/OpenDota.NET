namespace OpenDotaDotNet.Routes.PublicMatches.Models;

/// <summary>
/// Represents a public match.
/// </summary>
public class PublicMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("match_seq_num")]
	public long MatchSeqNum { get; set; }

	[JsonProperty("radiant_win")]
	public bool RadiantWin { get; set; }

	[JsonProperty("start_time")]
	public long StartTime { get; set; }

	[JsonProperty("duration")]
	public int Duration { get; set; }

	[JsonProperty("lobby_type")]
	public int LobbyType { get; set; }

	[JsonProperty("game_mode")]
	public int GameMode { get; set; }

	[JsonProperty("avg_rank_tier")]
	public int AvgRankTier { get; set; }

	[JsonProperty("num_rank_tier")]
	public int NumRankTier { get; set; }

	[JsonProperty("cluster")]
	public int Cluster { get; set; }

	[JsonProperty("radiant_team")]
	public int[] RadiantTeam { get; set; }

	[JsonProperty("dire_team")]
	public int[] DireTeam { get; set; }
}