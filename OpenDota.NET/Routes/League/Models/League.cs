namespace OpenDotaDotNet.Routes.League.Models;

/// <summary>
/// Represents a league.
/// </summary>
public class League
{
	[JsonPropertyName("leagueid")]
	public long LeagueId { get; set; }

	[JsonPropertyName("ticket")]
	public string Ticket { get; set; }

	[JsonPropertyName("banner")]
	public string Banner { get; set; }

	/// <summary>
	/// Gets or sets the tier for the tournament.
	/// </summary>
	[JsonPropertyName("tier")]
	public Tier? Tier { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }
}