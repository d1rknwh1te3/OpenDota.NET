namespace OpenDotaDotNet.Routes.Players.Models;

public class Player
{
	/// <summary>
	/// Gets or sets the solo competitive rank.
	/// </summary>
	[JsonPropertyName("solo_competitive_rank")]
	public int? SoloCompetitiveRank { get; set; }

	/// <summary>
	/// Gets or sets the competitive rank.
	/// </summary>
	[JsonPropertyName("competitive_rank")]
	public int? CompetitiveRank { get; set; }

	/// <summary>
	/// Gets or sets the rank tier.
	/// </summary>
	[JsonPropertyName("rank_tier")]
	public int? RankTier { get; set; }

	/// <summary>
	/// Gets or sets the leaderboard rank.
	/// </summary>
	[JsonPropertyName("leaderboard_rank")]
	public int? LeaderboardRank { get; set; }

	/// <summary>
	/// Gets or sets the profile.
	/// </summary>
	[JsonPropertyName("profile")]
	public Profile Profile { get; set; }
}