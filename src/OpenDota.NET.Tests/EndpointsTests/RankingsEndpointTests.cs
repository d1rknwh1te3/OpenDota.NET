namespace OpenDota.NET.Tests.EndpointsTests;

public class RankingsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetHeroRankings()
	{
		const int heroId = 40;
		var result = await _openDotaApi.Rankings.GetHeroRankingsAsync(heroId);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(heroId, result.HeroId);

			Assert.Equal(100, result.Rankings.Count());
			Assert.True(result.Rankings.All(x => x.AccountId > 0));
			Assert.Contains(result.Rankings, x => x.RankTier > 0);
			Assert.True(result.Rankings.All(x => x.RankTier is null or > 0));
			Assert.True(result.Rankings.All(x => x.Score > 0));
			Assert.Contains(result.Rankings, x => x.LastLogin > new DateTime(2000, 1, 1));
			Assert.True(result.Rankings.All(x => !x.LastLogin.HasValue || x.LastLogin > new DateTime(2000, 1, 1)));
			Assert.Contains(result.Rankings, x => !string.IsNullOrWhiteSpace(x.Name));
			Assert.True(result.Rankings.All(x => !string.IsNullOrWhiteSpace(x.Avatar.ToString())));
			Assert.True(result.Rankings.All(x => !string.IsNullOrWhiteSpace(x.Personaname)));
		}
	}
}