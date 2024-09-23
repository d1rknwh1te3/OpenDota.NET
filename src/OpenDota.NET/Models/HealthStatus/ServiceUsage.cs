namespace OpenDotaDotNet.Models.HealthStatus;

public class ServiceUsage
{
	/// <summary>
	/// Gets or sets the metric.
	/// </summary>
	[JsonProperty("metric")]
	public double Metric { get; set; }

	/// <summary>
	/// Gets or sets the threshold.
	/// </summary>
	[JsonProperty("threshold")]
	public long Threshold { get; set; }

	/// <summary>
	/// Gets or sets the timestamp.
	/// </summary>
	[JsonProperty("timestamp")]
	public long Timestamp { get; set; }
}