﻿namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a match team.
/// </summary>
public class MatchTeam
{
	// Id of team
	[JsonProperty("team_id")]
	public int TeamId { get; set; }

	// Name of the team
	[JsonProperty("name")]
	public string Name { get; set; }

	// Tag of the team
	[JsonProperty("tag")]
	public string Tag { get; set; }

	// Url of the team logo
	[JsonProperty("logo_url")]
	public Uri LogoUrl { get; set; }
}