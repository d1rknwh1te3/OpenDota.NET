using OpenDotaDotNet.Enums;
using OpenDotaDotNet.Routes.Scenarios.Enums;

namespace OpenDota.NET.Tests.EndpointsTests;

public class ScenariosEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetWinRateForCertainItemTimingsOnHeroes()
	{
		const int heroId = 40;
		const string itemName = "sange_and_yasha";

		var result = await _openDotaApi.Scenarios.GetItemNamingAsync(itemName, heroId);
		
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{

			Assert.True(result.Count >= 0);
			Assert.True(result.TrueForAll(x => x.Item == itemName));
			Assert.True(result.TrueForAll(x => x.HeroId == heroId));
			Assert.True(result.TrueForAll(x => x.Time >= 0));
			Assert.True(result.TrueForAll(x => x.Games >= 0));
			Assert.True(result.TrueForAll(x => x.Wins >= 0));
		}
	}

	[Fact]
	public async Task TestGetWinRateForHeroesInCertainLaneRoles()
	{
		const LaneRole laneId = LaneRole.Offlane; // Offlane
		const int heroId = 40; // Venomancer

		var result = await _openDotaApi.Scenarios.GetLaneRolesAsync(3, heroId); // TODO: FIX THIS SHIT
		
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.Count > 0);
			Assert.True(result.TrueForAll(x => x.LaneRole == laneId));
			Assert.True(result.TrueForAll(x => x.HeroId == heroId));
			Assert.True(result.TrueForAll(x => x.Time > 0));
			Assert.True(result.TrueForAll(x => x.Games > 0));
			Assert.True(result.TrueForAll(x => x.Wins >= 0));
		}
	}

	[Fact]
	public async Task TestGetMiscellaneousTeamScenarios()
	{
		const Scenario scenario = Scenario.CourierKill;

		var result =
			await _openDotaApi.Scenarios.GetMiscTeamScenariosAsync(scenario);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.Count > 0);
			Assert.True(result.TrueForAll(x => x.Scenario == scenario));
			Assert.True(result.TrueForAll(x => x.Games > 0));
			Assert.True(result.TrueForAll(x => x.Wins >= 0));
			Assert.True(result.TrueForAll(x => x.Region > 0));
		}
	}
}