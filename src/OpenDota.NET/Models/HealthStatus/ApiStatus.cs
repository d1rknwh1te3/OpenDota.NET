namespace OpenDotaDotNet.Models.HealthStatus;

public class ApiStatus
{
	[JsonProperty("status")]
	public int Status { get; set; }

	[JsonProperty("count")]
	public int Count { get; set; }
}