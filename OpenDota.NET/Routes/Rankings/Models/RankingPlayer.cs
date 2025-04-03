namespace OpenDotaDotNet.Routes.Rankings.Models;

public class RankingPlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	[JsonPropertyName("score")]
	public double Score { get; set; }

	[JsonPropertyName("personaname")]
	public string PersonaName { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("avatar")]
	public Uri Avatar { get; set; }

	[JsonPropertyName("last_login")]
	public DateTimeOffset? LastLogin { get; set; }

	[JsonPropertyName("rank_tier")]
	public int? RankTier { get; set; }
}