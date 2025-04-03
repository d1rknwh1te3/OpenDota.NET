namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents a pro player.
/// </summary>
public class PlayerPro
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("country_code")]
	public string CountryCode { get; set; }

	[JsonPropertyName("fantasy_role")]
	public long FantasyRole { get; set; }

	[JsonPropertyName("team_id")]
	public long TeamId { get; set; }

	[JsonPropertyName("team_name")]
	public string TeamName { get; set; }

	[JsonPropertyName("team_tag")]
	public string TeamTag { get; set; }

	[JsonPropertyName("is_locked")]
	public bool IsLocked { get; set; }

	[JsonPropertyName("is_pro")]
	public bool IsPro { get; set; }

	[JsonPropertyName("locked_until")]
	public object LockedUntil { get; set; }

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

	[JsonPropertyName("personaname")]
	public string PersonaName { get; set; }

	[JsonPropertyName("last_login")]
	public DateTimeOffset? LastLogin { get; set; }

	[JsonPropertyName("full_history_time")]
	public DateTimeOffset? FullHistoryTime { get; set; }

	[JsonPropertyName("cheese")]
	public long Cheese { get; set; }

	[JsonPropertyName("fh_unavailable")]
	public bool? FhUnavailable { get; set; }

	[JsonPropertyName("loccountrycode")]
	public string LocCountryCode { get; set; }

	[JsonPropertyName("last_match_time")]
	public DateTimeOffset LastMatchTime { get; set; }

	[JsonPropertyName("plus")]
	public bool? Plus { get; set; }

	[JsonPropertyName("last_played")]
	public long LastPlayed { get; set; }

	[JsonPropertyName("win")]
	public long Win { get; set; }

	[JsonPropertyName("games")]
	public long Games { get; set; }

	[JsonPropertyName("with_win")]
	public long WithWin { get; set; }

	[JsonPropertyName("with_games")]
	public long WithGames { get; set; }

	[JsonPropertyName("against_win")]
	public long AgainstWin { get; set; }

	[JsonPropertyName("against_games")]
	public long AgainstGames { get; set; }

	[JsonPropertyName("with_gpm_sum")]
	public long? WithGpmSum { get; set; }

	[JsonPropertyName("with_xpm_sum")]
	public long? WithXpmSum { get; set; }
}