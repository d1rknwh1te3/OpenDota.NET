namespace OpenDotaDotNet.Models.Leagues;

public class League
{
	[JsonProperty("leagueid")]
	public long Leagueid { get; set; }

	[JsonProperty("ticket")]
	public string Ticket { get; set; }

	[JsonProperty("banner")]
	public string Banner { get; set; }

	/// <summary>
	/// Gets or sets the tier for the tournament.
	/// </summary>
	[JsonProperty("tier")]
	public LeagueTier? Tier { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }
}