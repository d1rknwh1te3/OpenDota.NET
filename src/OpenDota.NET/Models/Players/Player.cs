namespace OpenDotaDotNet.Models.Players;

public class Player
{
	[JsonProperty("solo_competitive_rank")]
	public int? SoloCompetitiveRank { get; set; }

	[JsonProperty("competitive_rank")]
	public int? CompetitiveRank { get; set; }

	[JsonProperty("rank_tier")]
	public int? RankTier { get; set; }

	[JsonProperty("leaderboard_rank")]
	public int? LeaderboardRank { get; set; }

	[JsonProperty("profile")]
	public Profile Profile { get; set; }
}