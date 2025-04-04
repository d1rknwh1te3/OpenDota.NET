namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a player profile.
/// </summary>
public class Profile
{
	/// <summary>
	/// Gets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; init; }

	/// <summary>
	/// Gets the player's persona name.
	/// </summary>
	[JsonPropertyName("personaname")]
	public string PersonaName { get; init; } = string.Empty;

	/// <summary>
	/// Gets the player's real name.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = string.Empty;

	/// <summary>
	/// Gets whether the player has a plus account.
	/// </summary>
	[JsonPropertyName("plus")]
	public bool? Plus { get; init; }

	/// <summary>
	/// Gets the player's cheese count.
	/// </summary>
	[JsonPropertyName("cheese")]
	public long Cheese { get; init; }

	/// <summary>
	/// Gets the player's Steam ID.
	/// </summary>
	[JsonPropertyName("steamid")]
	public string SteamId { get; init; } = string.Empty;

	/// <summary>
	/// Gets the player's avatar.
	/// </summary>
	[JsonPropertyName("avatar")]
	public Uri? Avatar { get; init; }

	/// <summary>
	/// Gets the player's medium avatar.
	/// </summary>
	[JsonPropertyName("avatarmedium")]
	public Uri? AvatarMedium { get; init; }

	/// <summary>
	/// Gets the player's full avatar.
	/// </summary>
	[JsonPropertyName("avatarfull")]
	public Uri? AvatarFull { get; init; }

	/// <summary>
	/// Gets the player's profile URL.
	/// </summary>
	[JsonPropertyName("profileurl")]
	public Uri? ProfileUrl { get; init; }

	/// <summary>
	/// Gets the player's last login.
	/// </summary>
	[JsonPropertyName("last_login")]
	public DateTimeOffset? LastLogin { get; init; }

	/// <summary>
	/// Gets the player's location country code.
	/// </summary>
	[JsonPropertyName("loccountrycode")]
	public string LocCountryCode { get; init; }

	/// <summary>
	/// Gets whether the player is a contributor.
	/// </summary>
	[JsonPropertyName("is_contributor")]
	public bool IsContributor { get; init; }

	/// <summary>
	/// Gets whether the player is a subscriber.
	/// </summary>
	[JsonPropertyName("is_subscriber")]
	public bool IsSubscriber { get; init; }
}