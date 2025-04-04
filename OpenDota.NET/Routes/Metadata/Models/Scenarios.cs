namespace OpenDotaDotNet.Routes.Metadata.Models;

/// <summary>
/// Represents the scenarios.
/// </summary>
public class Scenarios
{
	/// <summary>
	/// Gets the item cost.
	/// </summary>
	[JsonPropertyName("itemCost")]
	public int ItemCost { get; init; }

	/// <summary>
	/// Gets the timings.
	/// </summary>
	[JsonPropertyName("timings")]
	public List<int> Timings { get; init; } = [];

	/// <summary>
	/// Gets the game duration bucket.
	/// </summary>
	[JsonPropertyName("gameDurationBucket")]
	public List<int> GameDurationBucket { get; init; } = [];

	/// <summary>
	/// Gets the team scenarios query parameters.
	/// </summary>
	[JsonPropertyName("teamScenariosQueryParams")]
	public List<int> TeamScenariosQueryParams { get; init; } = [];
}