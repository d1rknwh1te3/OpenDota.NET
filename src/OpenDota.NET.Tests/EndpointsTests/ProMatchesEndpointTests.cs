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
			var proMatches = result as ProMatch[] ?? result.ToArray();

			Assert.Equal(100, proMatches.Length);
			Assert.True(Array.TrueForAll(proMatches, x => !string.IsNullOrEmpty(x.LeagueName)));
			Assert.True(Array.TrueForAll(proMatches, x => x.MatchId > 0));
			Assert.True(Array.TrueForAll(proMatches, x => x.StartTime > 0));
		}
	}
}