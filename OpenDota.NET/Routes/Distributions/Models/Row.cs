namespace OpenDotaDotNet.Routes.Distributions.Models;

/// <summary>
/// Represents a row.
/// </summary>
public class Row
{
	[JsonPropertyName("bin")]
	public int Bin { get; set; }

	[JsonPropertyName("bin_name")]
	public string BinName { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("cumulative_sum")]
	public int CumulativeSum { get; set; }
}