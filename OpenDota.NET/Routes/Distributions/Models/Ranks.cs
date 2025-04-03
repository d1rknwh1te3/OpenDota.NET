namespace OpenDotaDotNet.Routes.Distributions.Models;

/// <summary>
/// Represents ranks.
/// </summary>
public class Ranks
{
	[JsonPropertyName("rows")]
	public Row[] Rows { get; set; }

	[JsonPropertyName("sum")]
	public Sum Sum { get; set; }
}