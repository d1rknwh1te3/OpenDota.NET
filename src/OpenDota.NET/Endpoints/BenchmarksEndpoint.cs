namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc />
public class BenchmarksEndpoint(Requester requester) : IBenchmarkEndpoint
{
	/// <inheritdoc />
	public Task<HeroBenchmark?> GetHeroBenchmarkAsync(int heroId) =>
		requester.GetResponseAsync<HeroBenchmark>(
			"benchmarks",
			[$"hero_id={heroId}"]);
}