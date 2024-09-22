namespace OpenDotaDotNet.Models.Metadata;

public class Cheese
{
	[JsonProperty("cheese")]
	public int CheeseAmount { get; set; }

	[JsonProperty("goal")]
	public int Goal { get; set; }
}