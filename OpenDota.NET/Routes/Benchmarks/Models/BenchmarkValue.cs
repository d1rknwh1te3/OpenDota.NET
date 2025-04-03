namespace OpenDotaDotNet.Routes.Benchmarks.Models;

/// <summary>
/// Represents a benchmark value.
/// </summary>
public class BenchmarkValue
{
	/// <summary>
	/// Gets or sets the percentile.
	/// </summary>
	[JsonPropertyName("percentile")]
	public double Percentile { get; set; }

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	[JsonPropertyName("value")]
	public double? Value { get; set; }
}