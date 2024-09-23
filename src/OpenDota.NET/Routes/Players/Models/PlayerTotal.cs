namespace OpenDotaDotNet.Routes.Players.Models;

public class PlayerTotal
{
	[JsonProperty("field")]
	public string Field { get; set; }

	[JsonProperty("n")]
	public long Number { get; set; }

	[JsonProperty("sum")]
	public double Sum { get; set; }
}