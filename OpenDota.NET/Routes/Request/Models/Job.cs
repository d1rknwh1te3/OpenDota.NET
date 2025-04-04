namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a job.
/// </summary>
public class Job
{
	/// <summary>
	/// Gets the job ID.
	/// </summary>
	[JsonPropertyName("jobId")]
	public long JobId { get; init; }
}