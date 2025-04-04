namespace OpenDotaDotNet.Routes.Metadata.Models;

/// <summary>
/// Represents the metadata.
/// </summary>
public class Metadata
{
	/// <summary>
	/// Gets the scenarios.
	/// </summary>
	[JsonPropertyName("scenarios")]
	public Scenarios Scenarios { get; init; } = new();

	/// <summary>
	/// Gets the user.
	/// </summary>
	[JsonPropertyName("user")]
	public User User { get; init; } = new();

	/// <summary>
	/// Gets the banner.
	/// </summary>
	[JsonPropertyName("banner")]
	public object? Banner { get; init; }

	/// <summary>
	/// Gets a value indicating whether this instance is subscriber.
	/// </summary>
	[JsonPropertyName("isSubscriber")]
	public bool IsSubscriber { get; init; }
}