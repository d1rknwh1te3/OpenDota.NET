namespace OpenDotaDotNet.Routes.Status.Models;

/// <summary>
/// Represents service usage.
/// </summary>
public class ServiceUsage
{
	/// <summary>
	/// Gets or sets the metric.
	/// </summary>
	[JsonPropertyName("metric")]
	public double Metric { get; set; }

	/// <summary>
	/// Gets or sets the threshold.
	/// </summary>
	[JsonPropertyName("threshold")]
	public long Threshold { get; set; }

	/// <summary>
	/// Gets or sets the timestamp.
	/// </summary>
	[JsonPropertyName("timestamp")]
	public long Timestamp { get; set; }
}