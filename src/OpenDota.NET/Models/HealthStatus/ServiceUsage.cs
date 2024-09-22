namespace OpenDotaDotNet.Models.HealthStatus;

public class ServiceUsage
{
	[JsonProperty("metric")]
	public double Metric { get; set; }

	[JsonProperty("threshold")]
	public long Threshold { get; set; }

	[JsonProperty("timestamp")]
	public long Timestamp { get; set; }
}