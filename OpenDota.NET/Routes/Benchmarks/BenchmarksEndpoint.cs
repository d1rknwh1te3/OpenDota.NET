namespace OpenDotaDotNet.Routes.Benchmarks;

/// <inheritdoc />
public class BenchmarksEndpoint(Requester requester) : IBenchmarkEndpoint
{
	/// <inheritdoc />
	public Task<Benchmark?> GetHeroBenchmarkAsync(int heroId) =>
		requester.GetResponseAsync<Benchmark>(
			"benchmarks",
			[$"hero_id={heroId}"]);
}