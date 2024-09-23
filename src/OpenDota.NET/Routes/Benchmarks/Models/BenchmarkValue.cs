namespace OpenDotaDotNet.Routes.Benchmarks.Models;

public class BenchmarkValue
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