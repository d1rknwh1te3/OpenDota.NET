namespace OpenDotaDotNet.Models.Distributions;

public class Ranks
{
	[JsonProperty("rows")]
	public Row[] Rows { get; set; }

	[JsonProperty("sum")]
	public Sum Sum { get; set; }
}