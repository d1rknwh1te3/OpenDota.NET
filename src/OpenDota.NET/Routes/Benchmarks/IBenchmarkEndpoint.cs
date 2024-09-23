namespace OpenDotaDotNet.Routes.Benchmarks;

/// <summary>
/// Benchmark endpoint.
/// </summary>
public interface IBenchmarkEndpoint
{
	/// <summary>
	/// Gets benchmarks of average stat values for a hero.
	/// </summary>
	/// <param name="heroId">Hero ID.</param>
	/// <returns>Benchmarks of average stat values for a hero.</returns>
	Task<Benchmark?> GetHeroBenchmarkAsync(int heroId);
}