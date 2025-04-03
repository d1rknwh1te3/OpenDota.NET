namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a player profile.
/// </summary>
public class Profile
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	[JsonPropertyName("personaname")]
	public string PersonaName { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("plus")]
	public bool? Plus { get; set; }

	[JsonPropertyName("cheese")]
	public long Cheese { get; set; }

	[JsonPropertyName("steamid")]
	public string SteamId { get; set; }

	[JsonPropertyName("avatar")]
	public Uri Avatar { get; set; }

	[JsonPropertyName("avatarmedium")]
	public Uri AvatarMedium { get; set; }

	[JsonPropertyName("avatarfull")]
	public Uri AvatarFull { get; set; }

	[JsonPropertyName("profileurl")]
	public Uri ProfileUrl { get; set; }

	[JsonPropertyName("last_login")]
	public DateTimeOffset? LastLogin { get; set; }

	[JsonPropertyName("loccountrycode")]
	public string LocCountryCode { get; set; }

	[JsonPropertyName("is_contributor")]
	public bool IsContributor { get; set; }

	[JsonPropertyName("is_subscriber")]
	public bool IsSubscriber { get; set; }
}