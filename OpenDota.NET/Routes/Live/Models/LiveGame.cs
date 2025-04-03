namespace OpenDotaDotNet.Routes.Live.Models;

/// <summary>
/// Represents a live game.
/// </summary>
public class LiveGame
{
	[JsonPropertyName("activate_time")]
	public long ActivateTime { get; set; }

	[JsonPropertyName("deactivate_time")]
	public long DeactivateTime { get; set; }

	[JsonPropertyName("server_steam_id")]
	public string ServerSteamId { get; set; }

	[JsonPropertyName("lobby_id")]
	public string LobbyId { get; set; }

	[JsonPropertyName("league_id")]
	public long LeagueId { get; set; }

	/// <summary>
	/// Gets or sets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonPropertyName("lobby_type")]
	public long LobbyType { get; set; }

	[JsonPropertyName("game_time")]
	public int GameTime { get; set; }

	[JsonPropertyName("delay")]
	public int Delay { get; set; }

	[JsonPropertyName("spectators")]
	public int Spectators { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonPropertyName("game_mode")]
	public int GameMode { get; set; }

	[JsonPropertyName("average_mmr")]
	public int AverageMmr { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	[JsonPropertyName("series_id")]
	public long SeriesId { get; set; }

	[JsonPropertyName("sort_score")]
	public long SortScore { get; set; }

	[JsonPropertyName("last_update_time")]
	public long LastUpdateTime { get; set; }

	[JsonPropertyName("radiant_lead")]
	public int RadiantLead { get; set; }

	[JsonPropertyName("radiant_score")]
	public int RadiantScore { get; set; }

	[JsonPropertyName("dire_score")]
	public int DireScore { get; set; }

	[JsonPropertyName("players")]
	public IEnumerable<LiveGamePlayer> Players { get; set; }

	[JsonPropertyName("building_state")]
	public long BuildingState { get; set; }

	[JsonPropertyName("team_name_radiant")]
	public string TeamNameRadiant { get; set; }

	[JsonPropertyName("team_name_dire")]
	public string TeamNameDire { get; set; }

	[JsonPropertyName("team_logo_radiant")]
	public string TeamLogoRadiant { get; set; }

	[JsonPropertyName("team_logo_dire")]
	public string TeamLogoDire { get; set; }

	[JsonPropertyName("team_id_radiant")]
	public long? TeamIdRadiant { get; set; }

	[JsonPropertyName("team_id_dire")]
	public long? TeamIdDire { get; set; }
}