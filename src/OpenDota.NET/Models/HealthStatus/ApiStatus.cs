namespace OpenDotaDotNet.Models.HealthStatus;

/// <summary>
/// Represents an API status.
/// </summary>
public class ApiStatus
{

	/// <summary>
	/// Gets or sets the status.
	/// </summary>
	[JsonProperty("status")]
	public int Status { get; set; }

	/// <summary>
	/// Gets or sets the count.
	/// </summary>
	[JsonProperty("count")]
	public int Count { get; set; }
}