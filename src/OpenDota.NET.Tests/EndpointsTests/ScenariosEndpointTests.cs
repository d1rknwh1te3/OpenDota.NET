namespace OpenDota.NET.Tests.EndpointsTests;

public class ScenariosEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetWinRateForCertainItemTimingsOnHeroes()
	{
		const int heroId = 40;
		const string itemName = "sange_and_yasha";
		var result =
			await _openDotaApi.Scenarios.GetWinRateForCertainItemTimingsOnHeroesAsync(itemName, heroId);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.Count() > 0);
		Assert.True(result.All(x => x.Item == itemName));
		Assert.True(result.All(x => x.HeroId == heroId));
		Assert.True(result.All(x => x.Time > 0));
		Assert.True(result.All(x => x.Games > 0));
		Assert.True(result.All(x => x.Wins > 0));
	}

	[Fact]
	public async Task TestGetWinRateForHeroesInCertainLaneRoles()
	{
		const int laneId = 3; // Offlane
		const int heroId = 40; // Venomancer
		var result =
			await _openDotaApi.Scenarios.GetWinRateForHeroesInCertainLaneRolesAsync(3, 40);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.Count() > 0);
		Assert.True(result.All(x => x.LaneRole == laneId));
		Assert.True(result.All(x => x.HeroId == heroId));
		Assert.True(result.All(x => x.Time > 0));
		Assert.True(result.All(x => x.Games > 0));
		Assert.True(result.All(x => x.Wins > 0));
	}

	[Fact]
	public async Task TestGetMiscellaneousTeamScenarios()
	{
		const string scenario = "courier_kill";
		var result =
			await _openDotaApi.Scenarios.GetMiscellaneousTeamScenariosAsync(scenario);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.Count() > 0);
		Assert.True(result.All(x => x.Scenario == scenario));
		Assert.True(result.All(x => x.Games > 0));
		Assert.True(result.All(x => x.Wins > 0));
		Assert.True(result.All(x => x.Region > 0));
		Assert.True(result.Count(x => x.IsRadiant) == result.Count(x => !x.IsRadiant));
	}
}