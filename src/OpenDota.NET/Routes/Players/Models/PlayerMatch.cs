namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerMatch
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonProperty("player_slot")]
	public int PlayerSlot { get; set; }

	/// <summary>
	/// Gets or sets whether Radiant won the match.
	/// </summary>
	[JsonProperty("radiant_win")]
	public bool? RadiantWin { get; set; }

	/// <summary>
	/// Gets or sets the duration of the game in seconds.
	/// </summary>
	[JsonProperty("duration")]
	public int Duration { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonProperty("game_mode")]
	public int GameMode { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonProperty("lobby_type")]
	public int LobbyType { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// Gets or sets time the game started in seconds since 1970.
	/// </summary>
	[JsonProperty("start_time")]
	public long StartTime { get; set; }

	/// <summary>
	/// Gets or sets the version.
	/// </summary>
	[JsonProperty("version")]
	public int? Version { get; set; }

	/// <summary>
	/// Gets or sets total kills the player had at the end of the game.
	/// </summary>
	[JsonProperty("kills")]
	public int Kills { get; set; }

	/// <summary>
	/// Gets or sets total deaths the player had at the end of the game.
	/// </summary>
	[JsonProperty("deaths")]
	public int Deaths { get; set; }

	/// <summary>
	/// Gets or sets total assists the player had at the end of the game.
	/// </summary>
	[JsonProperty("assists")]
	public int Assists { get; set; }

	/// <summary>
	/// Gets or sets skill bracket assigned by Valve (Normal, High, Very High).
	/// </summary>
	[JsonProperty("skill")]
	public int? Skill { get; set; }

	/// <summary>
	/// Gets or sets integer describing whether or not the player left the game. 0: didn't leave. 1: left safely. 2+: Abandoned.
	/// </summary>
	[JsonProperty("leaver_status")]
	public int LeaverStatus { get; set; }

	/// <summary>
	/// Gets or sets size of the player's party.
	/// </summary>
	[JsonProperty("party_size")]
	public int? PartySize { get; set; }

	[JsonProperty("average_rank")]
	public int? AverageRank { get; set; }

	// 1-indexed facet, see https://github.com/odota/dotaconstants/blob/master/build/hero_abilities.json
	[JsonProperty("hero_variant")]
	public int? HeroVariant { get; set; }

	/// <summary>
	/// Gets or sets the heroes.
	/// (requires ?project=heroes).
	/// </summary>
	[JsonProperty("heroes")]
	public Dictionary<string, PlayerMatchHero> Heroes { get; set; }
}