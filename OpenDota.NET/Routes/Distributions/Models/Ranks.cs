namespace OpenDotaDotNet.Routes.Distributions.Models;

/// <summary>
/// Represents ranks.
/// </summary>
public class Ranks
{
	[JsonProperty("rows")]
	public Row[] Rows { get; set; }

	[JsonProperty("sum")]
	public Sum Sum { get; set; }
}