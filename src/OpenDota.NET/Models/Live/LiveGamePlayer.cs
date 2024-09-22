namespace OpenDotaDotNet.Models.Live;

public class LiveGamePlayer
{
	[JsonProperty("account_id")]
	public long AccountId { get; set; }

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