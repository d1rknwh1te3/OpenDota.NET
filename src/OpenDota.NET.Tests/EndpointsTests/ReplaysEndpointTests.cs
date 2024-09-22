namespace OpenDota.NET.Tests.EndpointsTests;

public class ReplaysEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	//[Fact]
	//public async Task TestGetReplayData()
	//{
	//	var proMatches = await _openDotaApi.ProMatches.GetProMatchesAsync();
	//	var result =
	//		await _openDotaApi.Replays.GetReplayDataAsync(proMatches.Select(x => x.MatchId).Take(2));
	//	testOutputHelper.WriteLine(result.ToJsonString());

	//	Assert.Equal(2, result.Count());
	//	Assert.True(result.All(x => x.MatchId > 0));
	//	Assert.True(result.All(x => x.Cluster > 0));
	//	Assert.True(result.All(x => x.ReplaySalt > 0));
	//	Assert.True(result.All(x => x.SeriesId > 0));
	//	Assert.True(result.All(x => x.SeriesType > 0));
	//}
}