﻿namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player ward map.
/// </summary>
public class PlayerWardMap
{
	[JsonProperty("obs")]
	public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

	[JsonProperty("sen")]
	public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
}