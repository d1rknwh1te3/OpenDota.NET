namespace OpenDotaDotNet.Models.Request;

public class ParseRequest
{
	[JsonProperty("job")]
	public Job Job { get; set; }
}