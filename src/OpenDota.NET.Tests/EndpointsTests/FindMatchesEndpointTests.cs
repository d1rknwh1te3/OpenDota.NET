using OpenDotaDotNet.Models.FindMatches;

namespace OpenDota.NET.Tests.EndpointsTests;

public class FindMatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestFindMatchesByHeroesPlayed()
	{
		var result = await _openDotaApi.FindMatches.FindMatchesByHeroesPlayedAsync(
			[27, 40],
			[1, 2]);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var findMatches = result as FindMatch[] ?? result.ToArray();

			Assert.Equal(10, findMatches.Count());
			Assert.True(
				findMatches.All(
					x => x.TeamA.Contains(27) && x.TeamA.Contains(40)
					     || x.TeamB.Contains(27) && x.TeamB.Contains(40)));
			Assert.True(
				findMatches.All(
					x => x.TeamA.Contains(1) && x.TeamA.Contains(2)
					     || x.TeamB.Contains(1) && x.TeamB.Contains(2)));
			Assert.True(findMatches.All(x => x.StartTime > 0));
			Assert.True(findMatches.All(x => x.MatchId > 0));
		}
	}
}