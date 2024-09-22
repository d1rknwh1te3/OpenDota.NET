namespace OpenDotaDotNet.Models.HealthStatus;

public class ServiceStatistics
{
	[JsonProperty("user_players")]
	public int UserPlayers { get; set; }

	[JsonProperty("user_players_recent")]
	public int UserPlayersRecent { get; set; }

	[JsonProperty("tracked_players")]
	public int TrackedPlayers { get; set; }

	[JsonProperty("matches_last_day")]
	public int MatchesLastDay { get; set; }

	[JsonProperty("matches_prev_hour")]
	public int MatchesPrevHour { get; set; }

	[JsonProperty("distinct_match_players_last_day")]
	public int DistinctMatchPlayersLastDay { get; set; }

	[JsonProperty("distinct_match_players_user_last_day")]
	public int DistinctMatchPlayersUserLastDay { get; set; }

	[JsonProperty("distinct_match_players_recent_user_last_day")]
	public int DistinctMatchPlayersRecentUserLastDay { get; set; }

	[JsonProperty("distinct_requests_last_day")]
	public int DistinctRequestsLastDay { get; set; }

	[JsonProperty("auto_parse_last_day")]
	public int AutoParseLastDay { get; set; }

	[JsonProperty("requests_last_day")]
	public int RequestsLastDay { get; set; }

	[JsonProperty("requests_ui_day")]
	public int RequestsUiDay { get; set; }

	[JsonProperty("requests_api_key_last_day")]
	public int RequestsApiKeyLastDay { get; set; }

	[JsonProperty("registry_retriever")]
	public int RegistryRetriever { get; set; }

	[JsonProperty("registry_parser")]
	public int RegistryParser { get; set; }

	[JsonProperty("retriever_matches_current_hour")]
	public int RetrieverMatchesCurrentHour { get; set; }

	[JsonProperty("retriever_matches_last_day")]
	public int RetrieverMatchesLastDay { get; set; }

	[JsonProperty("retriever_players_last_day")]
	public int RetrieverPlayersLastDay { get; set; }

	[JsonProperty("parse_jobs_last_day")]
	public int ParseJobsLastDay { get; set; }

	[JsonProperty("parse_fails_last_day")]
	public int ParseFailsLastDay { get; set; }

	[JsonProperty("parse_crashes_last_day")]
	public int ParseCrashesLastDay { get; set; }

	[JsonProperty("parsed_matches_last_day")]
	public int ParsedMatchesLastDay { get; set; }

	[JsonProperty("reparse_early_last_day")]
	public int ReparseEarlyLastDay { get; set; }

	[JsonProperty("reapi_last_day")]
	public int ReapiLastDay { get; set; }

	[JsonProperty("regcdata_last_day")]
	public int RegcdataLastDay { get; set; }

	[JsonProperty("reparse_last_day")]
	public int ReparseLastDay { get; set; }

	[JsonProperty("oldparse_last_day")]
	public int OldparseLastDay { get; set; }

	[JsonProperty("meta_parsed_last_day")]
	public int MetaParsedLastDay { get; set; }

	[JsonProperty("fullhistory_last_day")]
	public int FullhistoryLastDay { get; set; }

	[JsonProperty("fullhistory_short_last_day")]
	public int FullhistoryShortLastDay { get; set; }

	[JsonProperty("fullhistory_ops_last_day")]
	public int FullhistoryOpsLastDay { get; set; }

	[JsonProperty("fullhistory_skips_last_day")]
	public int FullhistorySkipsLastDay { get; set; }

	[JsonProperty("steam_api_calls_last_day")]
	public int SteamApiCallsLastDay { get; set; }

	[JsonProperty("steam_proxy_calls_last_day")]
	public int SteamProxyCallsLastDay { get; set; }

	[JsonProperty("steam_429_last_day")]
	public int Steam429LastDay { get; set; }

	[JsonProperty("steam_403_last_day")]
	public int Steam403LastDay { get; set; }

	[JsonProperty("steam_api_backfill_last_day")]
	public int SteamApiBackfillLastDay { get; set; }

	[JsonProperty("steam_api_notfound_last_day")]
	public int SteamApiNotfoundLastDay { get; set; }

	[JsonProperty("steam_gc_backfill_last_day")]
	public int SteamGcBackfillLastDay { get; set; }

	[JsonProperty("match_archive_read_last_day")]
	public int MatchArchiveReadLastDay { get; set; }

	[JsonProperty("match_archive_write_last_day")]
	public int MatchArchiveWriteLastDay { get; set; }

	[JsonProperty("incomplete_archive_last_day")]
	public int IncompleteArchiveLastDay { get; set; }

	[JsonProperty("api_hits_last_day")]
	public int ApiHitsLastDay { get; set; }

	[JsonProperty("api_hits_ui_last_day")]
	public int ApiHitsUiLastDay { get; set; }

	[JsonProperty("build_match_last_day")]
	public int BuildMatchLastDay { get; set; }

	[JsonProperty("get_player_matches_last_day")]
	public int GetPlayerMatchesLastDay { get; set; }

	[JsonProperty("self_player_matches_last_day")]
	public int SelfPlayerMatchesLastDay { get; set; }

	[JsonProperty("match_cache_hit_last_day")]
	public int MatchCacheHitLastDay { get; set; }

	[JsonProperty("player_cache_hit_last_day")]
	public int PlayerCacheHitLastDay { get; set; }

	[JsonProperty("player_cache_miss_last_day")]
	public int PlayerCacheMissLastDay { get; set; }

	[JsonProperty("player_cache_wait_last_day")]
	public int PlayerCacheWaitLastDay { get; set; }

	[JsonProperty("player_cache_write_last_day")]
	public int PlayerCacheWriteLastDay { get; set; }

	[JsonProperty("distinct_player_cache_last_day")]
	public int DistinctPlayerCacheLastDay { get; set; }

	[JsonProperty("auto_player_cache_hit_last_day")]
	public int AutoPlayerCacheHitLastDay { get; set; }

	[JsonProperty("auto_player_cache_miss_last_day")]
	public int AutoPlayerCacheMissLastDay { get; set; }

	[JsonProperty("auto_player_cache_last_day")]
	public int AutoPlayerCacheLastDay { get; set; }

	[JsonProperty("distinct_auto_player_cache_last_day")]
	public int DistinctAutoPlayerCacheLastDay { get; set; }

	[JsonProperty("error_last_day")]
	public int ErrorLastDay { get; set; }

	[JsonProperty("web_crash_last_day")]
	public int WebCrashLastDay { get; set; }

	[JsonProperty("skip_seq_num_last_day")]
	public int SkipSeqNumLastDay { get; set; }

	[JsonProperty("secondary_scanner_last_day")]
	public int SecondaryScannerLastDay { get; set; }

	/// <summary>
	/// Gets or sets the load times.
	/// </summary>
	[JsonProperty("load_times")]
	public IDictionary<string, long> LoadTimes { get; set; }

	/// <summary>
	/// Gets or sets the API status.
	/// </summary>
	[JsonProperty("api_status")]
	public IEnumerable<ApiStatus> ApiStatus { get; set; }

	/// <summary>
	/// Gets or sets the health.
	/// </summary>
	[JsonProperty("health")]
	public ServiceHealth Health { get; set; }
}