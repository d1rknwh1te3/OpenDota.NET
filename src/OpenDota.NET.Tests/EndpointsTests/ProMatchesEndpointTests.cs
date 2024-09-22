namespace OpenDota.NET.Tests.EndpointsTests;

public class ProMatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetProMatches()
	{
		var result = await _openDotaApi.ProMatches.GetProMatchesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.Equal(100, result.Count());
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.LeagueName)));
		Assert.True(result.All(x => x.MatchId > 0));
		Assert.True(result.All(x => x.StartTime > 0));
	}
}