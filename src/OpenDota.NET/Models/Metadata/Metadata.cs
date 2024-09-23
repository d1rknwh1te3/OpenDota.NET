namespace OpenDotaDotNet.Models.Metadata;

/// <summary>
/// Represents the metadata.
/// </summary>
public class Metadata
{
	/// <summary>
	/// Gets or sets the scenarios.
	/// </summary>
	[JsonProperty("scenarios")]
	public Scenarios Scenarios { get; set; }

	/// <summary>
	/// Gets or sets the user.
	/// </summary>
	[JsonProperty("user")]
	public User User { get; set; }

	/// <summary>
	/// Gets or sets the banner.
	/// </summary>
	[JsonProperty("banner")]
	public object? Banner { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether this instance is subscriber.
	/// </summary>
	[JsonProperty("isSubscriber")]
	public bool IsSubscriber { get; set; }
}