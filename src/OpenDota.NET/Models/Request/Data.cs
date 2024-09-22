﻿namespace OpenDotaDotNet.Models.Request;

public class Data
{
	[JsonProperty("match_id")]
	public long MatchId { get; set; }

	[JsonProperty("radiant_win")]
	public bool RadiantWin { get; set; }

	[JsonProperty("start_time")]
	public long StartTime { get; set; }

	[JsonProperty("duration")]
	public int Duration { get; set; }

	[JsonProperty("pgroup")]
	public Dictionary<string, Pgroup> Pgroup { get; set; }

	[JsonProperty("ability_upgrades")]
	public IEnumerable<object> AbilityUpgrades { get; set; }
}