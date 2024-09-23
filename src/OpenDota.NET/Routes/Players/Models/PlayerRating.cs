namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerRating
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public required long AccountId { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long? MatchId { get; set; }

	[JsonProperty("solo_competitive_rank")]
	public int? SoloCompetitiveRank { get; set; }

	[JsonProperty("competitive_rank")]
	public int? CompetitiveRank { get; set; }

	[JsonProperty("time")]
	public DateTimeOffset Time { get; set; }
}