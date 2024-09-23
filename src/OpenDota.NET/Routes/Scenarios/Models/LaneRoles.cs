namespace OpenDotaDotNet.Routes.Scenarios.Models;

/// <summary>
/// Represents lane roles.
/// </summary>
public class LaneRoles
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// The hero's lane role
	/// </summary>
	[JsonProperty("lane_role")]
	public LaneRole LaneRole { get; set; }

	/// <summary>
	/// Maximum game length in seconds
	/// </summary>
	[JsonProperty("time")]
	public int Time { get; set; }

	/// <summary>
	/// The number of games where the hero played in this lane role
	/// </summary>
	[JsonProperty("games")]
	public int Games { get; set; }

	/// <summary>
	/// The number of games won where the hero played in this lane role
	/// </summary>
	[JsonProperty("wins")]
	public int Wins { get; set; }
}