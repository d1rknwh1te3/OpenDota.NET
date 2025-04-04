namespace OpenDotaDotNet.Routes.Live.Models;

/// <summary>
/// Represents a live game.
/// </summary>
public class LiveGame
{
	[JsonPropertyName("activate_time")]
	public long ActivateTime { get; init; }

	[JsonPropertyName("average_mmr")]
	public int AverageMmr { get; init; }
	[JsonPropertyName("building_state")]

	public long BuildingState { get; init; }
	[JsonPropertyName("deactivate_time")]

	public long DeactivateTime { get; init; }
	[JsonPropertyName("delay")]

	public int Delay { get; init; }
	[JsonPropertyName("dire_score")]

	public int DireScore { get; init; }

	/// <summary>
	/// Gets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonPropertyName("game_mode")]
	public int GameMode { get; init; }

	[JsonPropertyName("game_time")]
	public int GameTime { get; init; }

	[JsonPropertyName("last_update_time")]
	public long LastUpdateTime { get; init; }

	[JsonPropertyName("league_id")]
	public long LeagueId { get; init; }

	[JsonPropertyName("lobby_id")]
	public string LobbyId { get; init; } = string.Empty;

	/// <summary>
	/// Gets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonPropertyName("lobby_type")]

	public long? LobbyType { get; init; }

	/// <summary>
	/// Gets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]

	public long? MatchId { get; init; }

	[JsonPropertyName("players")]
	public List<LiveGamePlayer> Players { get; init; } = [];

	[JsonPropertyName("radiant_lead")]

	public int RadiantLead { get; init; }

	[JsonPropertyName("radiant_score")]

	public int RadiantScore { get; init; }

	[JsonPropertyName("series_id")]

	public long? SeriesId { get; init; }

	[JsonPropertyName("server_steam_id")]
	public string ServerSteamId { get; init; } = string.Empty;
	
	[JsonPropertyName("sort_score")]

	public long? SortScore { get; init; }

	[JsonPropertyName("spectators")]

	public int Spectators { get; init; }

	[JsonPropertyName("team_id_dire")]

	public long? TeamIdDire { get; init; }

	[JsonPropertyName("team_id_radiant")]

	public long? TeamIdRadiant { get; init; }

	[JsonPropertyName("team_logo_dire")]
	public string TeamLogoDire { get; init; } = string.Empty;

	[JsonPropertyName("team_logo_radiant")]
	public string TeamLogoRadiant { get; init; } = string.Empty;

	[JsonPropertyName("team_name_dire")]
	public string TeamNameDire { get; init; } = string.Empty;

	[JsonPropertyName("team_name_radiant")]
	public string TeamNameRadiant { get; init; } = string.Empty;
}