namespace OpenDotaDotNet.Routes.Status.Models;

/// <summary>
/// Represents an API status.
/// </summary>
public class ApiStatus
{

	/// <summary>
	/// Gets or sets the status.
	/// </summary>
	[JsonPropertyName("status")]
	public int Status { get; set; }

	/// <summary>
	/// Gets or sets the count.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }
}