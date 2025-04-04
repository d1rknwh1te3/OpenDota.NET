namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a parse request.
/// </summary>
public class ParseRequest
{
	/// <summary>
	/// Gets the job to parse.
	/// </summary>
	[JsonPropertyName("job")]
	public Job Job { get; init; } = new();
}