using OpenDotaDotNet.Routes.FindMatches.Models;

namespace OpenDota.NET.Tests.EndpointsTests;

public class FindMatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestFindMatchesByHeroesPlayed()
	{
		var result = await _openDotaApi.FindMatches.FindMatchesByHeroesPlayedAsync(
			[27],
			[2]);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var findMatches = result as FindMatch[] ?? result.ToArray();

			Assert.Equal(10, findMatches.Length);
			Assert.True(Array.TrueForAll(findMatches, x => x.TeamA.Contains(27) || x.TeamB.Contains(27)));
			Assert.True(Array.TrueForAll(findMatches, x => x.TeamA.Contains(2) || x.TeamB.Contains(2)));
			Assert.True(Array.TrueForAll(findMatches, x => x.StartTime > 0));
			Assert.True(Array.TrueForAll(findMatches, x => x.MatchId > 0));
		}
	}
}