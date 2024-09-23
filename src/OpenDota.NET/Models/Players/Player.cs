namespace OpenDotaDotNet.Models.Players;

public class Player
{
	/// <summary>
	/// Gets or sets the solo competitive rank.
	/// </summary>
	[JsonProperty("solo_competitive_rank")]
	public int? SoloCompetitiveRank { get; set; }

	/// <summary>
	/// Gets or sets the competitive rank.
	/// </summary>
	[JsonProperty("competitive_rank")]
	public int? CompetitiveRank { get; set; }

	/// <summary>
	/// Gets or sets the rank tier.
	/// </summary>
	[JsonProperty("rank_tier")]
	public int? RankTier { get; set; }

	/// <summary>
	/// Gets or sets the leaderboard rank.
	/// </summary>
	[JsonProperty("leaderboard_rank")]
	public int? LeaderboardRank { get; set; }

	/// <summary>
	/// Gets or sets the profile.
	/// </summary>
	[JsonProperty("profile")]
	public Profile Profile { get; set; }
}