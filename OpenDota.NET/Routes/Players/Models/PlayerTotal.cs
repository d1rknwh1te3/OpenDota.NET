namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player total.
/// </summary>
public class PlayerTotal
{
	[JsonProperty("field")]
	public string Field { get; set; }

	[JsonProperty("n")]
	public long Number { get; set; }

	[JsonProperty("sum")]
	public double Sum { get; set; }
}