namespace OpenDotaDotNet.Models.Benchmarks;

public class HeroBenchmarkValue
{
	/// <summary>
	/// Gets or sets the percentile.
	/// </summary>
	[JsonProperty("percentile")]
	public double Percentile { get; set; }

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	[JsonProperty("value")]
	public double? Value { get; set; }
}