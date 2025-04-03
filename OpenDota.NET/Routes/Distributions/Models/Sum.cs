namespace OpenDotaDotNet.Routes.Distributions.Models;

/// <summary>
/// Represents a sum.
/// </summary>
public class Sum
{
	[JsonPropertyName("count")]
	public long Count { get; set; }
}