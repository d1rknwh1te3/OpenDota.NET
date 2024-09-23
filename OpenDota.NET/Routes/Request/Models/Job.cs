namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a job.
/// </summary>
public class Job
{
	[JsonProperty("jobId")]
	public long JobId { get; set; }
}