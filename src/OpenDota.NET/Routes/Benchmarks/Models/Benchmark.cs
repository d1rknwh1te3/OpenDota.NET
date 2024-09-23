namespace OpenDotaDotNet.Routes.Benchmarks.Models;

public class Benchmark
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonProperty("hero_id")]
	public long HeroId { get; set; }

	/// <summary>
	/// Gets or sets the result.
	/// </summary>
	[JsonProperty("result")]
	public BenchmarkResult Result { get; set; }
}