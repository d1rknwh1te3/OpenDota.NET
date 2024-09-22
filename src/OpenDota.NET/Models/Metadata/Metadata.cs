namespace OpenDotaDotNet.Models.Metadata;

public class Metadata
{
	[JsonProperty("scenarios")]
	public Scenarios Scenarios { get; set; }

	[JsonProperty("user")]
	public User User { get; set; }

	[JsonProperty("banner")]
	public object Banner { get; set; }

	[JsonProperty("cheese")]
	public Cheese Cheese { get; set; }
}