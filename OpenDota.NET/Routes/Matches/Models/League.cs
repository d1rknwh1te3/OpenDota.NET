namespace OpenDotaDotNet.Routes.Matches.Models;

public class League
{
	/// <summary>
	/// Gets or sets the league ID.
	/// </summary>
	[JsonProperty("leagueid")]
	public long LeagueId { get; set; }

	// always null?
	[JsonProperty("ticket")]
	public object Ticket { get; set; }

	// Banner of the league - always returns null?
	[JsonProperty("banner")]
	public object Banner { get; set; }

	/// <summary>
	/// Gets or sets tier of the league.
	/// </summary>
	[JsonProperty("tier")]
	public Tier Tier { get; set; }

	/// <summary>
	/// Gets or sets name of the league.
	/// </summary>
	[JsonProperty("name")]
	public string? Name { get; set; }
}