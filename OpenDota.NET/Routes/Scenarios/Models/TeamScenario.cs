namespace OpenDotaDotNet.Routes.Scenarios.Models;

/// <summary>
/// Represents a team scenario.
/// </summary>
public class TeamScenario
{
	/// <summary>
	/// Gets the scenario's name or description.
	/// </summary>
	[JsonPropertyName("scenario")]
	public Scenario Scenario { get; init; }

	/// <summary>
	/// Gets a value indicating whether Radiant executed this scenario.
	/// </summary>
	[JsonPropertyName("is_radiant")]
	public bool IsRadiant { get; init; }

	/// <summary>
	/// Gets region the game was played in.
	/// </summary>
	[JsonPropertyName("region")]
	public int Region { get; init; }

	/// <summary>
	/// Gets the number of games where this scenario occurred.
	/// </summary>
	[JsonPropertyName("games")]
	public int Games { get; init; }

	/// <summary>
	/// Gets the number of games won where this scenario occured.
	/// </summary>
	[JsonPropertyName("wins")]
	public int Wins { get; init; }
}