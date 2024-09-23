namespace OpenDotaDotNet.Routes.Rankings.Models;

public class RankingPlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public required long AccountId { get; set; }

	[JsonProperty("score")]
	public double Score { get; set; }

	[JsonProperty("personaname")]
	public string PersonaName { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("avatar")]
	public Uri Avatar { get; set; }

	[JsonProperty("last_login")]
	public DateTimeOffset? LastLogin { get; set; }

	[JsonProperty("rank_tier")]
	public int? RankTier { get; set; }
}