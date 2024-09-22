namespace OpenDota.NET.Tests.EndpointsTests;

public class LeaguesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetLeagues()
	{
		var result = await _openDotaApi.League.GetLeaguesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.Count() >= 3322);
		Assert.Contains(result, x => x.Tier == LeagueTier.Amateur);
		Assert.Contains(result, x => x.Tier == LeagueTier.Excluded);
		Assert.Contains(result, x => x.Tier == LeagueTier.Premium);
		Assert.Contains(result, x => x.Tier == LeagueTier.Professional);
		Assert.Contains(result, x => x.Leagueid > 0);
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.Name)));
		Assert.Contains(result, x => !string.IsNullOrEmpty(x.Banner));
		Assert.Contains(result, x => !string.IsNullOrEmpty(x.Ticket));
	}
}