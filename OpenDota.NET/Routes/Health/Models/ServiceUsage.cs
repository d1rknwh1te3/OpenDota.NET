namespace OpenDotaDotNet.Routes.Health.Models;

/// <summary>
/// Represents service usage.
/// </summary>
public class ServiceUsage
{
	/// <summary>
	/// Gets the metric.
	/// </summary>
	[JsonPropertyName("metric")]

	public double Metric { get; init; }

	/// <summary>
	/// Gets the threshold.
	/// </summary>
	[JsonPropertyName("threshold")]

	public long? Threshold { get; init; }

	/// <summary>
	/// Gets the timestamp.
	/// </summary>
	[JsonPropertyName("timestamp")]

	public long? Timestamp { get; init; }
}