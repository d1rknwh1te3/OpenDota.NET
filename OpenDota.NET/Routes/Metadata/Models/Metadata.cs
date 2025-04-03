namespace OpenDotaDotNet.Routes.Metadata.Models;

/// <summary>
/// Represents the metadata.
/// </summary>
public class Metadata
{
	/// <summary>
	/// Gets or sets the scenarios.
	/// </summary>
	[JsonPropertyName("scenarios")]
	public Scenarios Scenarios { get; set; }

	/// <summary>
	/// Gets or sets the user.
	/// </summary>
	[JsonPropertyName("user")]
	public User User { get; set; }

	/// <summary>
	/// Gets or sets the banner.
	/// </summary>
	[JsonPropertyName("banner")]
	public object? Banner { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether this instance is subscriber.
	/// </summary>
	[JsonPropertyName("isSubscriber")]
	public bool IsSubscriber { get; set; }
}