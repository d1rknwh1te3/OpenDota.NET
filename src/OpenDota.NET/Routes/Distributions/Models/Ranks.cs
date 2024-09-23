namespace OpenDotaDotNet.Routes.Distributions.Models;

public class Ranks
{
	[JsonProperty("rows")]
	public Row[] Rows { get; set; }

	[JsonProperty("sum")]
	public Sum Sum { get; set; }
}