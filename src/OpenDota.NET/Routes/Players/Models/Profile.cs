namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a player profile.
/// </summary>
public class Profile
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public required long AccountId { get; set; }

	[JsonProperty("personaname")]
	public string PersonaName { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("plus")]
	public bool? Plus { get; set; }

	[JsonProperty("cheese")]
	public long Cheese { get; set; }

	[JsonProperty("steamid")]
	public string SteamId { get; set; }

	[JsonProperty("avatar")]
	public Uri Avatar { get; set; }

	[JsonProperty("avatarmedium")]
	public Uri AvatarMedium { get; set; }

	[JsonProperty("avatarfull")]
	public Uri AvatarFull { get; set; }

	[JsonProperty("profileurl")]
	public Uri ProfileUrl { get; set; }

	[JsonProperty("last_login")]
	public DateTimeOffset? LastLogin { get; set; }

	[JsonProperty("loccountrycode")]
	public string LocCountryCode { get; set; }

	[JsonProperty("is_contributor")]
	public bool IsContributor { get; set; }

	[JsonProperty("is_subscriber")]
	public bool IsSubscriber { get; set; }
}