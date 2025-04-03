﻿namespace OpenDotaDotNet.Routes.Matches.Models;

public class Match
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	// Bitmask. An integer that represents a binary of which barracks are still standing. 63 would mean all barracks still stand at the end of the game.
	[JsonPropertyName("barracks_status_dire")]
	public int BarracksStatusDire { get; set; }

	// Bitmask. An integer that represents a binary of which barracks are still standing. 63 would mean all barracks still stand at the end of the game.
	[JsonPropertyName("barracks_status_radiant")]
	public int BarracksStatusRadiant { get; set; }

	[JsonPropertyName("chat")]
	public IEnumerable<Chat> Chat { get; set; }

	[JsonPropertyName("cluster")]
	public int Cluster { get; set; }

	[JsonPropertyName("cosmetics")]
	public IDictionary<string, long> Cosmetics { get; set; }

	[JsonPropertyName("dire_score")]
	public int DireScore { get; set; }

	// The ID of dire team
	[JsonPropertyName("dire_team_id")]
	public int? DireTeamId { get; set; }

	// Draft (pick) timings and info
	[JsonPropertyName("draft_timings")]
	public IEnumerable<DraftTiming> DraftTimings { get; set; }

	// Duration of the game in seconds
	[JsonPropertyName("duration")]
	public int Duration { get; set; }

	[JsonPropertyName("engine")]
	public int Engine { get; set; }

	// Time (in seconds) of game when first blood was drawn
	[JsonPropertyName("first_blood_time")]
	public long FirstBloodTime { get; set; }

	/// <summary>
	/// Gets or sets an integer corresponding to game mode played.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/game_mode.json.
	/// </summary>
	[JsonPropertyName("game_mode")]
	public int GameMode { get; set; }

	// Number of human players in the game
	[JsonPropertyName("human_players")]
	public int HumanPlayers { get; set; }

	// The ID of league
	[JsonPropertyName("leagueid")]
	public int LeagueId { get; set; }

	/// <summary>
	/// Gets or sets integer corresponding to lobby type of match.
	/// List of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/lobby_type.json.
	/// </summary>
	[JsonPropertyName("lobby_type")]
	public long LobbyType { get; set; }

	[JsonPropertyName("match_seq_num")]
	public long MatchSeqNum { get; set; }

	// Number of negative votes the replay received in the in-game client
	[JsonPropertyName("negative_votes")]
	public long NegativeVotes { get; set; }

	// Game objectives
	[JsonPropertyName("objectives")]
	public IEnumerable<Objective> Objectives { get; set; }

	// Object containing information on the draft. Each pick/ban contains a boolean relating to whether the choice is a pick or a ban, the hero ID, the team the picked or banned it, and the order
	[JsonPropertyName("picks_bans")]
	public IEnumerable<PickBan> PicksBans { get; set; }

	// Number of positive votes the replay received in the in-game client
	[JsonPropertyName("positive_votes")]
	public int PositiveVotes { get; set; }

	// Array of the Radiant gold advantage at each minute in the game. A negative number means that Radiant is behind, and thus it is their gold disadvantage.
	[JsonPropertyName("radiant_gold_adv")]
	public IEnumerable<int> RadiantGoldAdvantage { get; set; }

	// Final score for Radiant (number of kills on Radiant)
	[JsonPropertyName("radiant_score")]
	public int RadiantScore { get; set; }

	// Id of the Radiant team
	[JsonPropertyName("radiant_team_id")]
	public int? RadiantTeamId { get; set; }

	// Boolean indicating whether Radiant won the match
	[JsonPropertyName("radiant_win")]
	public bool RadiantWin { get; set; }

	// Array of the Radiant experience advantage at each minute in the game. A negative number means that Radiant is behind, and thus it is their experience disadvantage.
	[JsonPropertyName("radiant_xp_adv")]
	public IEnumerable<int> RadiantXpAdvantage { get; set; }

	// The skill level of the game
	[JsonPropertyName("skill")]
	public int? Skill { get; set; }

	/// <summary>
	/// Gets or sets the Unix timestamp at which the game started.
	/// </summary>
	[JsonPropertyName("start_time")]
	public long StartTime { get; set; }

	/// <summary>
	/// Gets or sets the detailed list of teamfights.
	/// </summary>
	[JsonPropertyName("teamfights")]
	public IEnumerable<Teamfight> Teamfights { get; set; }

	/// <summary>
	/// Gets or sets the bitmask. An integer that represents a binary of which Dire towers are still standing.
	/// </summary>
	[JsonPropertyName("tower_status_dire")]
	public int TowerStatusDire { get; set; }

	/// <summary>
	/// Gets or sets the bitmask. An integer that represents a binary of which Radiant towers are still standing.
	/// </summary>
	[JsonPropertyName("tower_status_radiant")]
	public int TowerStatusRadiant { get; set; }

	/// <summary>
	/// Gets or sets parse version, used internally by OpenDota.
	/// </summary>
	[JsonPropertyName("version")]
	public int? Version { get; set; }

	/// <summary>
	/// Gets or sets salt of the replay file.
	/// </summary>
	[JsonPropertyName("replay_salt")]
	public long ReplaySalt { get; set; }

	[JsonPropertyName("series_id")]
	public long SeriesId { get; set; }

	[JsonPropertyName("series_type")]
	public long SeriesType { get; set; }

	// Information about the league (if any)
	[JsonPropertyName("league")]
	public League League { get; set; }

	// Radiant team information
	[JsonPropertyName("radiant_team")]
	public MatchTeam RadiantTeam { get; set; }

	// Dire team information
	[JsonPropertyName("dire_team")]
	public MatchTeam DireTeam { get; set; }

	// Array of information on individual players
	[JsonPropertyName("players")]
	public IEnumerable<MatchPlayer> Players { get; set; }

	// Information on the patch version the game is played on
	[JsonPropertyName("patch")]
	public int Patch { get; set; }

	/// <summary>
	/// Gets or sets the integer corresponding to the region the game was played on.
	/// </summary>
	[JsonPropertyName("region")]
	public int Region { get; set; }

	/// <summary>
	/// Gets or sets word counts of the all chat messages in the player's games (string - message, int - amount of times used).
	/// </summary>
	[JsonPropertyName("all_word_counts")]
	public IDictionary<string, int> AllWordCounts { get; set; }

	// Word counts of the player's all chat messages
	[JsonPropertyName("my_word_counts")]
	public IDictionary<string, int> MyWordCounts { get; set; }

	/// <summary>
	/// Gets or sets the maximum gold advantage of the player's team if they lost the match.
	/// </summary>
	[JsonPropertyName("throw")]
	public int Throw { get; set; }

	/// <summary>
	/// Gets or sets the maximum gold disadvantage of the player's team if they won the match.
	/// </summary>
	[JsonPropertyName("comeback")]
	public int Comeback { get; set; }

	[JsonPropertyName("stomp")]
	public int Stomp { get; set; }

	/// <summary>
	/// Gets or sets the maximum gold disadvantage of the player's team if they lost the match.
	/// </summary>
	[JsonPropertyName("loss")]
	public int Loss { get; set; }

	/// <summary>
	/// Gets or sets the maximum gold advantage of the player's team if they won the match.
	/// </summary>
	[JsonPropertyName("win")]
	public int Win { get; set; }

	/// <summary>
	/// Gets or sets the replay URL.
	/// </summary>
	[JsonPropertyName("replay_url")]
	public Uri ReplayUrl { get; set; }
}