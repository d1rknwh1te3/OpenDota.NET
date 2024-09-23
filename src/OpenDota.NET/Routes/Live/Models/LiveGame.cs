namespace OpenDotaDotNet.Routes.Live.Models;

/// <summary>
/// Represents a live game.
/// </summary>
public class LiveGame
{
	[JsonProperty("activate_time")]
	public long ActivateTime { get; set; }

	[JsonProperty("deactivate_time")]
	public long DeactivateTime { get; set; }

	[JsonProperty("server_steam_id")]
	public string ServerSteamId { get; set; }

	[JsonProperty("lobby_id")]
	public string LobbyId { get; set; }

	[JsonProperty("league_id")]
	public long LeagueId { get; set; }

	/// <summary>
	/// Gets or sets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonProperty("lobby_type")]
	public long LobbyType { get; set; }

	[JsonProperty("game_time")]
	public int GameTime { get; set; }

	[JsonProperty("delay")]
	public int Delay { get; set; }

	[JsonProperty("spectators")]
	public int Spectators { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonProperty("game_mode")]
	public int GameMode { get; set; }

	[JsonProperty("average_mmr")]
	public int AverageMmr { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("series_id")]
	public long SeriesId { get; set; }

	[JsonProperty("sort_score")]
	public long SortScore { get; set; }

	[JsonProperty("last_update_time")]
	public long LastUpdateTime { get; set; }

	[JsonProperty("radiant_lead")]
	public int RadiantLead { get; set; }

	[JsonProperty("radiant_score")]
	public int RadiantScore { get; set; }

	[JsonProperty("dire_score")]
	public int DireScore { get; set; }

	[JsonProperty("players")]
	public IEnumerable<LiveGamePlayer> Players { get; set; }

	[JsonProperty("building_state")]
	public long BuildingState { get; set; }

	[JsonProperty("team_name_radiant")]
	public string TeamNameRadiant { get; set; }

	[JsonProperty("team_name_dire")]
	public string TeamNameDire { get; set; }

	[JsonProperty("team_logo_radiant")]
	public string TeamLogoRadiant { get; set; }

	[JsonProperty("team_logo_dire")]
	public string TeamLogoDire { get; set; }

	[JsonProperty("team_id_radiant")]
	public long? TeamIdRadiant { get; set; }

	[JsonProperty("team_id_dire")]
	public long? TeamIdDire { get; set; }
}