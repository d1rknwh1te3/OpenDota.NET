namespace OpenDota.NET.Tests.EndpointsTests;

public class BenchmarksEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetHeroBenchmark()
	{
		const int heroId = 2;

		var result = await _openDotaApi.Benchmarks.GetHeroBenchmarkAsync(heroId);

		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(heroId, result.HeroId);
			Assert.NotNull(result.Result);
			Assert.Equal(11, result.Result.GoldPerMinutes.Count);
			Assert.Equal(11, result.Result.XpPerMinutes.Count);
			Assert.Equal(11, result.Result.KillsPerMinutes.Count);
			Assert.Equal(11, result.Result.LastHitPerMinutes.Count);
			Assert.Equal(11, result.Result.HeroDamagePerMinutes.Count);
			Assert.Equal(11, result.Result.HeroHealingPerMinutes.Count);
			Assert.Equal(11, result.Result.TowerDamage.Count);
		}
	}
}