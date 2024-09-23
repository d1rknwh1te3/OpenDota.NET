using OpenDotaDotNet.Routes.PublicMatches.Models;

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
			var publicMatches = result as PublicMatch[] ?? result.ToArray();

			Assert.True(Array.TrueForAll(publicMatches, x => x.MatchId > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.AvgRankTier > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.Cluster > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.Duration > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.GameMode > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.LobbyType >= 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.MatchSeqNum > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.NumRankTier > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.StartTime > 0));
			Assert.True(Array.TrueForAll(publicMatches, x => x.RadiantTeam.Length == 5));
			Assert.True(Array.TrueForAll(publicMatches, x => x.DireTeam.Length == 5));
		}
	}
}