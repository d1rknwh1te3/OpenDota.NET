namespace OpenDotaDotNet.Routes.Players.Models;

public class Player
{
	/// <summary>
	/// Gets the solo competitive rank.
	/// </summary>
	[JsonPropertyName("solo_competitive_rank")]
	public int SoloCompetitiveRank { get; init; }

	/// <summary>
	/// Gets the competitive rank.
	/// </summary>
	[JsonPropertyName("competitive_rank")]
	public int CompetitiveRank { get; init; }

	/// <summary>
	/// Gets the rank tier.
	/// </summary>
	[JsonPropertyName("rank_tier")]
	public int RankTier { get; init; }

	/// <summary>
	/// Gets the leaderboard rank.
	/// </summary>
	[JsonPropertyName("leaderboard_rank")]
	public int LeaderboardRank { get; init; }

	/// <summary>
	/// Gets the profile.
	/// </summary>
	[JsonPropertyName("profile")]
	public Profile Profile { get; init; } = new();
}