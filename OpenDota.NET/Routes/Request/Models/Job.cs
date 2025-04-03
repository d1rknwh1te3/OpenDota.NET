namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a job.
/// </summary>
public class Job
{
	[JsonPropertyName("jobId")]
	public long JobId { get; set; }
}