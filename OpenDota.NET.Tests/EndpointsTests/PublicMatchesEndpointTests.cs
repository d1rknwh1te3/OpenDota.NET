namespace OpenDota.NET.Tests.EndpointsTests;

public class PublicMatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetPublicMatches()
	{
		var result = await _openDotaApi.PublicMatches.GetPublicMatchesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.TrueForAll(x => x.MatchId > 0));
			Assert.True(result.TrueForAll(x => x.AvgRankTier > 0));
			Assert.True(result.TrueForAll(x => x.Cluster > 0));
			Assert.True(result.TrueForAll(x => x.Duration > 0));
			Assert.True(result.TrueForAll(x => x.GameMode > 0));
			Assert.True(result.TrueForAll(x => x.LobbyType >= 0));
			Assert.True(result.TrueForAll(x => x.MatchSeqNum > 0));
			Assert.True(result.TrueForAll(x => x.NumRankTier > 0));
			Assert.True(result.TrueForAll(x => x.StartTime > 0));
			Assert.True(result.TrueForAll(x => x.RadiantTeam.Length == 5));
			Assert.True(result.TrueForAll(x => x.DireTeam.Length == 5));
		}
	}
}