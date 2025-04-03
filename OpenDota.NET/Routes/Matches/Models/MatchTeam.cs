namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a match team.
/// </summary>
public class MatchTeam
{
	// Id of team
	[JsonPropertyName("team_id")]
	public int TeamId { get; set; }

	// Name of the team
	[JsonPropertyName("name")]
	public string Name { get; set; }

	// Tag of the team
	[JsonPropertyName("tag")]
	public string Tag { get; set; }

	// Url of the team logo
	[JsonPropertyName("logo_url")]
	public Uri LogoUrl { get; set; }
}