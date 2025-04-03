namespace OpenDotaDotNet.Routes.Matches.Models;

public class League
{
	/// <summary>
	/// Gets or sets the league ID.
	/// </summary>
	[JsonPropertyName("leagueid")]
	public long LeagueId { get; set; }

	// always null?
	[JsonPropertyName("ticket")]
	public object Ticket { get; set; }

	// Banner of the league - always returns null?
	[JsonPropertyName("banner")]
	public object Banner { get; set; }

	/// <summary>
	/// Gets or sets tier of the league.
	/// </summary>
	[JsonPropertyName("tier")]
	public Tier Tier { get; set; }

	/// <summary>
	/// Gets or sets name of the league.
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; }
}