﻿namespace OpenDotaDotNet.Models.FindMatches;

public class FindMatch
{
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("teama")]
	public IEnumerable<int> TeamA { get; set; }

	[JsonProperty("teamb")]
	public IEnumerable<int> TeamB { get; set; }

	[JsonProperty("teamawin")]
	public bool TeamAWin { get; set; }

	[JsonProperty("start_time")]
	public long StartTime { get; set; }
}