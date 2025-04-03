namespace OpenDotaDotNet.Routes.Scenarios.Models;

/// <summary>
/// Represents lane roles.
/// </summary>
public class LaneRoles
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// The hero's lane role
	/// </summary>
	[JsonPropertyName("lane_role")]
	public LaneRole LaneRole { get; set; }

	/// <summary>
	/// Maximum game length in seconds
	/// </summary>
	[JsonPropertyName("time")]
	public int Time { get; set; }

	/// <summary>
	/// The number of games where the hero played in this lane role
	/// </summary>
	[JsonPropertyName("games")]
	public int Games { get; set; }

	/// <summary>
	/// The number of games won where the hero played in this lane role
	/// </summary>
	[JsonPropertyName("wins")]
	public int Wins { get; set; }
}