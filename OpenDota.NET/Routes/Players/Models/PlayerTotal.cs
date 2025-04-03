namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player total.
/// </summary>
public class PlayerTotal
{
	[JsonPropertyName("field")]
	public string Field { get; set; }

	[JsonPropertyName("n")]
	public long Number { get; set; }

	[JsonPropertyName("sum")]
	public double Sum { get; set; }
}