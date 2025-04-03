namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player rating.
/// </summary>
public class PlayerRating
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long? MatchId { get; set; }

	[JsonPropertyName("solo_competitive_rank")]
	public int? SoloCompetitiveRank { get; set; }

	[JsonPropertyName("competitive_rank")]
	public int? CompetitiveRank { get; set; }

	[JsonPropertyName("time")]
	public DateTimeOffset Time { get; set; }
}