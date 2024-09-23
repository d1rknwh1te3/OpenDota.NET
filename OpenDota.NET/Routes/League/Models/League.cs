namespace OpenDotaDotNet.Routes.League.Models;

/// <summary>
/// Represents a league.
/// </summary>
public class League
{
	[JsonProperty("leagueid")]
	public long LeagueId { get; set; }

	[JsonProperty("ticket")]
	public string Ticket { get; set; }

	[JsonProperty("banner")]
	public string Banner { get; set; }

	/// <summary>
	/// Gets or sets the tier for the tournament.
	/// </summary>
	[JsonProperty("tier")]
	public Tier? Tier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}