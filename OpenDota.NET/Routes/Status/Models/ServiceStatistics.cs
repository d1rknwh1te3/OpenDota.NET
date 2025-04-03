namespace OpenDotaDotNet.Routes.Status.Models;

/// <summary>
/// Represents service statistics.
/// </summary>
public class ServiceStatistics
{
	[JsonPropertyName("user_players")]
	public int UserPlayers { get; set; }

	[JsonPropertyName("user_players_recent")]
	public int UserPlayersRecent { get; set; }

	[JsonPropertyName("tracked_players")]
	public int TrackedPlayers { get; set; }

	[JsonPropertyName("matches_last_day")]
	public int MatchesLastDay { get; set; }

	[JsonPropertyName("matches_prev_hour")]
	public int MatchesPrevHour { get; set; }

	[JsonPropertyName("distinct_match_players_last_day")]
	public int DistinctMatchPlayersLastDay { get; set; }

	[JsonPropertyName("distinct_match_players_user_last_day")]
	public int DistinctMatchPlayersUserLastDay { get; set; }

	[JsonPropertyName("distinct_match_players_recent_user_last_day")]
	public int DistinctMatchPlayersRecentUserLastDay { get; set; }

	[JsonPropertyName("distinct_requests_last_day")]
	public int DistinctRequestsLastDay { get; set; }

	[JsonPropertyName("auto_parse_last_day")]
	public int AutoParseLastDay { get; set; }

	[JsonPropertyName("requests_last_day")]
	public int RequestsLastDay { get; set; }

	[JsonPropertyName("requests_ui_day")]
	public int RequestsUiDay { get; set; }

	[JsonPropertyName("requests_api_key_last_day")]
	public int RequestsApiKeyLastDay { get; set; }

	[JsonPropertyName("registry_retriever")]
	public int RegistryRetriever { get; set; }

	[JsonPropertyName("registry_parser")]
	public int RegistryParser { get; set; }

	[JsonPropertyName("retriever_matches_current_hour")]
	public int RetrieverMatchesCurrentHour { get; set; }

	[JsonPropertyName("retriever_matches_last_day")]
	public int RetrieverMatchesLastDay { get; set; }

	[JsonPropertyName("retriever_players_last_day")]
	public int RetrieverPlayersLastDay { get; set; }

	[JsonPropertyName("parse_jobs_last_day")]
	public int ParseJobsLastDay { get; set; }

	[JsonPropertyName("parse_fails_last_day")]
	public int ParseFailsLastDay { get; set; }

	[JsonPropertyName("parse_crashes_last_day")]
	public int ParseCrashesLastDay { get; set; }

	[JsonPropertyName("parsed_matches_last_day")]
	public int ParsedMatchesLastDay { get; set; }

	[JsonPropertyName("reparse_early_last_day")]
	public int ReparseEarlyLastDay { get; set; }

	[JsonPropertyName("reapi_last_day")]
	public int ReapiLastDay { get; set; }

	[JsonPropertyName("regcdata_last_day")]
	public int RegcdataLastDay { get; set; }

	[JsonPropertyName("reparse_last_day")]
	public int ReparseLastDay { get; set; }

	[JsonPropertyName("oldparse_last_day")]
	public int OldparseLastDay { get; set; }

	[JsonPropertyName("meta_parsed_last_day")]
	public int MetaParsedLastDay { get; set; }

	[JsonPropertyName("fullhistory_last_day")]
	public int FullhistoryLastDay { get; set; }

	[JsonPropertyName("fullhistory_short_last_day")]
	public int FullhistoryShortLastDay { get; set; }

	[JsonPropertyName("fullhistory_ops_last_day")]
	public int FullhistoryOpsLastDay { get; set; }

	[JsonPropertyName("fullhistory_skips_last_day")]
	public int FullhistorySkipsLastDay { get; set; }

	[JsonPropertyName("steam_api_calls_last_day")]
	public int SteamApiCallsLastDay { get; set; }

	[JsonPropertyName("steam_proxy_calls_last_day")]
	public int SteamProxyCallsLastDay { get; set; }

	[JsonPropertyName("steam_429_last_day")]
	public int Steam429LastDay { get; set; }

	[JsonPropertyName("steam_403_last_day")]
	public int Steam403LastDay { get; set; }

	[JsonPropertyName("steam_api_backfill_last_day")]
	public int SteamApiBackfillLastDay { get; set; }

	[JsonPropertyName("steam_api_notfound_last_day")]
	public int SteamApiNotfoundLastDay { get; set; }

	[JsonPropertyName("steam_gc_backfill_last_day")]
	public int SteamGcBackfillLastDay { get; set; }

	[JsonPropertyName("match_archive_read_last_day")]
	public int MatchArchiveReadLastDay { get; set; }

	[JsonPropertyName("match_archive_write_last_day")]
	public int MatchArchiveWriteLastDay { get; set; }

	[JsonPropertyName("incomplete_archive_last_day")]
	public int IncompleteArchiveLastDay { get; set; }

	[JsonPropertyName("api_hits_last_day")]
	public int ApiHitsLastDay { get; set; }

	[JsonPropertyName("api_hits_ui_last_day")]
	public int ApiHitsUiLastDay { get; set; }

	[JsonPropertyName("build_match_last_day")]
	public int BuildMatchLastDay { get; set; }

	[JsonPropertyName("get_player_matches_last_day")]
	public int GetPlayerMatchesLastDay { get; set; }

	[JsonPropertyName("self_player_matches_last_day")]
	public int SelfPlayerMatchesLastDay { get; set; }

	[JsonPropertyName("match_cache_hit_last_day")]
	public int MatchCacheHitLastDay { get; set; }

	[JsonPropertyName("player_cache_hit_last_day")]
	public int PlayerCacheHitLastDay { get; set; }

	[JsonPropertyName("player_cache_miss_last_day")]
	public int PlayerCacheMissLastDay { get; set; }

	[JsonPropertyName("player_cache_wait_last_day")]
	public int PlayerCacheWaitLastDay { get; set; }

	[JsonPropertyName("player_cache_write_last_day")]
	public int PlayerCacheWriteLastDay { get; set; }

	[JsonPropertyName("distinct_player_cache_last_day")]
	public int DistinctPlayerCacheLastDay { get; set; }

	[JsonPropertyName("auto_player_cache_hit_last_day")]
	public int AutoPlayerCacheHitLastDay { get; set; }

	[JsonPropertyName("auto_player_cache_miss_last_day")]
	public int AutoPlayerCacheMissLastDay { get; set; }

	[JsonPropertyName("auto_player_cache_last_day")]
	public int AutoPlayerCacheLastDay { get; set; }

	[JsonPropertyName("distinct_auto_player_cache_last_day")]
	public int DistinctAutoPlayerCacheLastDay { get; set; }

	[JsonPropertyName("error_last_day")]
	public int ErrorLastDay { get; set; }

	[JsonPropertyName("web_crash_last_day")]
	public int WebCrashLastDay { get; set; }

	[JsonPropertyName("skip_seq_num_last_day")]
	public int SkipSeqNumLastDay { get; set; }

	[JsonPropertyName("secondary_scanner_last_day")]
	public int SecondaryScannerLastDay { get; set; }

	/// <summary>
	/// Gets or sets the load times.
	/// </summary>
	[JsonPropertyName("load_times")]
	public required IDictionary<string, long> LoadTimes { get; set; }

	/// <summary>
	/// Gets or sets the API status.
	/// </summary>
	[JsonPropertyName("api_status")]
	public required IEnumerable<ApiStatus> ApiStatus { get; set; }

	/// <summary>
	/// Gets or sets the health.
	/// </summary>
	[JsonPropertyName("health")]
	public required ServiceHealth Health { get; set; }
}