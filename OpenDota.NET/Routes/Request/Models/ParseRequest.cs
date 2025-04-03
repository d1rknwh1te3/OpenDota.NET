namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a parse request.
/// </summary>
public class ParseRequest
{
	[JsonPropertyName("job")]
	public Job Job { get; set; }
}