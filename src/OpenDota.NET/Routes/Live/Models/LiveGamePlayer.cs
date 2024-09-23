namespace OpenDotaDotNet.Routes.Live.Models;

/// <summary>
/// Represents a player in a live game.
/// </summary>
public class LiveGamePlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public required long AccountId { get; set; }

	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("country_code")]
	public string CountryCode { get; set; }

	[JsonProperty("fantasy_role")]
	public long? FantasyRole { get; set; }

	[JsonProperty("team_id")]
	public long? TeamId { get; set; }

	[JsonProperty("team_name")]
	public string TeamName { get; set; }

	[JsonProperty("team_tag")]
	public string TeamTag { get; set; }

	[JsonProperty("is_locked")]
	public bool? IsLocked { get; set; }

	[JsonProperty("is_pro")]
	public bool? IsPro { get; set; }

	[JsonProperty("locked_until")]
	public object LockedUntil { get; set; }
}