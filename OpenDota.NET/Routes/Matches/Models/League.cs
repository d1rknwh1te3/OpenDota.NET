namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a league
/// </summary>
public class League
{
	/// <summary>
	/// Gets the league ID.
	/// </summary>
	[JsonPropertyName("leagueid")]
	public long LeagueId { get; init; }

	/// <summary>
	/// Gets ticket?? always null?
	/// </summary>
	[JsonPropertyName("ticket")]
	public object? Ticket { get; init; }

	/// <summary>
	/// Gets banner of the league - always returns null?
	/// </summary>
	[JsonPropertyName("banner")]
	public object? Banner { get; init; }

	/// <summary>
	/// Gets tier of the league.
	/// </summary>
	[JsonPropertyName("tier")]
	public Tier Tier { get; init; }

	/// <summary>
	/// Gets name of the league.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = string.Empty;
}