namespace OpenDotaDotNet.Models.Benchmarks;

public class HeroBenchmark
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
	public HeroBenchmarkResult Result { get; set; }
}