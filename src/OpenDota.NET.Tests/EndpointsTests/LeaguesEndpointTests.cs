namespace OpenDota.NET.Tests.EndpointsTests;

public class LeaguesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetLeagues()
	{
		var result = await _openDotaApi.League.GetLeaguesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var leagues = result as League[] ?? result.ToArray();
			Assert.True(leagues.Length >= 3322);
			Assert.Contains(leagues, x => x.Tier == LeagueTier.Amateur);
			Assert.Contains(leagues, x => x.Tier == LeagueTier.Excluded);
			Assert.Contains(leagues, x => x.Tier == LeagueTier.Premium);
			Assert.Contains(leagues, x => x.Tier == LeagueTier.Professional);
			Assert.Contains(leagues, x => x.Leagueid > 0);
			Assert.True(Array.TrueForAll(leagues, x => !string.IsNullOrEmpty(x.Name)));
			Assert.Contains(leagues, x => !string.IsNullOrEmpty(x.Banner));
			Assert.Contains(leagues, x => !string.IsNullOrEmpty(x.Ticket));
		}
	}
}