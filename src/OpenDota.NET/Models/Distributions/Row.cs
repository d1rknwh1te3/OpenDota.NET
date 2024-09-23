namespace OpenDotaDotNet.Models.Distributions;

public class Row
{
	[JsonProperty("bin")]
	public int Bin { get; set; }

	[JsonProperty("bin_name")]
	public string BinName { get; set; }

	[JsonProperty("count")]
	public int Count { get; set; }

	[JsonProperty("cumulative_sum")]
	public int CumulativeSum { get; set; }
}