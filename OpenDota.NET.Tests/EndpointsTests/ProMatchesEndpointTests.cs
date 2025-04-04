namespace OpenDota.NET.Tests.EndpointsTests;

public class ProMatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetProMatches()
	{
		var result = await _openDotaApi.ProMatches.GetProMatchesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(100, result.Count);
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.LeagueName)));
			Assert.True(result.TrueForAll(x => x.MatchId > 0));
			Assert.True(result.TrueForAll(x => x.StartTime > 0));
		}
	}
}