namespace OpenDotaDotNet.Routes.Status.Models;

/// <summary>
/// Represents an API path.
/// </summary>
public class ApiPath
{
	/// <summary>
	/// Gets or sets the hostname.
	/// </summary>
	[JsonPropertyName("hostname")]
	public string Hostname { get; set; }

	/// <summary>
	/// Gets or sets the count.
	/// </summary>
	[JsonPropertyName("count")]
	public string Count { get; set; }
}