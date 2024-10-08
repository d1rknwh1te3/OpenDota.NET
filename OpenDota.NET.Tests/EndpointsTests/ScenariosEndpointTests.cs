﻿using OpenDotaDotNet.Enums;
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

		var result =
			await _openDotaApi.Scenarios.GetItemNamingAsync(itemName, heroId);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var timings = result as ItemTiming[] ?? result.ToArray();

			Assert.True(timings.Length > 0);
			Assert.True(Array.TrueForAll(timings, x => x.Item == itemName));
			Assert.True(Array.TrueForAll(timings, x => x.HeroId == heroId));
			Assert.True(Array.TrueForAll(timings, x => x.Time > 0));
			Assert.True(Array.TrueForAll(timings, x => x.Games > 0));
			Assert.True(Array.TrueForAll(timings, x => x.Wins > 0));
		}
	}

	[Fact]
	public async Task TestGetWinRateForHeroesInCertainLaneRoles()
	{
		const LaneRole laneId = LaneRole.Offlane; // Offlane
		const int heroId = 40; // Venomancer

		var result =
			await _openDotaApi.Scenarios.GetLaneRolesAsync(3, heroId); // TODO: FIX THIS SHIT
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var roleWinrates = result as LaneRoles[] ?? result.ToArray();

			Assert.True(roleWinrates.Length > 0);
			Assert.True(Array.TrueForAll(roleWinrates, x => x.LaneRole == laneId));
			Assert.True(Array.TrueForAll(roleWinrates, x => x.HeroId == heroId));
			Assert.True(Array.TrueForAll(roleWinrates, x => x.Time > 0));
			Assert.True(Array.TrueForAll(roleWinrates, x => x.Games > 0));
			Assert.True(Array.TrueForAll(roleWinrates, x => x.Wins >= 0));
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
			var scenarios = result as TeamScenario[] ?? result.ToArray();

			Assert.True(scenarios.Length > 0);
			Assert.True(Array.TrueForAll(scenarios, x => x.Scenario == scenario));
			Assert.True(Array.TrueForAll(scenarios, x => x.Games > 0));
			Assert.True(Array.TrueForAll(scenarios, x => x.Wins >= 0));
			Assert.True(Array.TrueForAll(scenarios, x => x.Region > 0));
		}
	}
}