namespace OpenDotaDotNet.Models.Players;

public class Profile
{
	[JsonProperty("account_id")]
	public long AccountId { get; set; }

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