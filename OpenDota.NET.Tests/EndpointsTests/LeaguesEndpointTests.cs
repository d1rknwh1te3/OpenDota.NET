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
			Assert.True(result.Count >= 3322);
			Assert.Contains(result, x => x.Tier == Tier.Amateur);
			Assert.Contains(result, x => x.Tier == Tier.Excluded);
			Assert.Contains(result, x => x.Tier == Tier.Premium);
			Assert.Contains(result, x => x.Tier == Tier.Professional);
			Assert.Contains(result, x => x.LeagueId > 0);
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.Contains(result, x => !string.IsNullOrWhiteSpace(x.Banner));
			Assert.Contains(result, x => !string.IsNullOrWhiteSpace(x.Ticket));
		}
	}
}