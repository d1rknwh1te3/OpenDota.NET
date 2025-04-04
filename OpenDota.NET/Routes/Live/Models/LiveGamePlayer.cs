namespace OpenDotaDotNet.Routes.Live.Models;

/// <summary>
/// Represents a player in a live game.
/// </summary>
public class LiveGamePlayer
{
	/// <summary>
	/// Gets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public  long AccountId { get; init; }

	/// <summary>
	/// Gets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; init; }

	/// <summary>
	/// Gets the name of the player.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("country_code")]
	public string CountryCode { get; init; } = string.Empty;

	/// <summary>
	/// Gets a fantasy role code
	/// </summary>
	[JsonPropertyName("fantasy_role")]
	public long FantasyRole { get; init; }

	/// <summary>
	/// Gets a team ID
	/// </summary>
	[JsonPropertyName("team_id")]
	public long TeamId { get; init; }

	/// <summary>
	/// Gets a team name
	/// </summary>
	[JsonPropertyName("team_name")]
	public string TeamName { get; init; } = string.Empty;

	/// <summary>
	/// Gets a team tag
	/// </summary>
	[JsonPropertyName("team_tag")]
	public string TeamTag { get; init; } = string.Empty;

	/// <summary>
	/// Gets a value indicating whether the player is locked.
	/// </summary>
	[JsonPropertyName("is_locked")]
	public bool IsLocked { get; init; }

	/// <summary>
	/// Gets a value indicating whether the player is pro.
	/// </summary>
	[JsonPropertyName("is_pro")]
	public bool IsPro { get; init; }

	/// <summary>
	/// TODO: IDK
	/// </summary>
	[JsonPropertyName("locked_until")]
	public object? LockedUntil { get; init; }
}