﻿namespace OpenDotaDotNet.Routes.Scenarios;

/// <inheritdoc />
public class ScenariosEndpoint(Requester requester) : IScenariosEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ItemTiming>?> GetItemNamingAsync(string? item = null, int? heroId = null) =>
		requester.GetResponseAsync<IEnumerable<ItemTiming>>(
			"scenarios/itemTimings",
			GetArguments(item, heroId));

	/// <inheritdoc />
	public Task<IEnumerable<LaneRoles>?> GetLaneRolesAsync(int? laneRole = null, int? heroId = null) =>
		requester.GetResponseAsync<IEnumerable<LaneRoles>>(
			"scenarios/laneRoles",
			GetArguments(null, heroId, laneRole));

	/// <inheritdoc />
	public Task<IEnumerable<TeamScenario>?> GetMiscTeamScenariosAsync(Scenario? scenario = null) =>
		requester.GetResponseAsync<IEnumerable<TeamScenario>>(
			"scenarios/misc",
			GetArguments(null, null, null, scenario));

	private static List<string> GetArguments(string? item = null, int? heroId = null, int? laneRole = null, Scenario? scenario = null)
	{
		var addedArguments = new List<string>();

		if (item != null)
			addedArguments.Add($"item={item}");

		if (heroId != null)
			addedArguments.Add($"hero_id={heroId}");

		if (laneRole != null)
			addedArguments.Add($"lane_role={laneRole}");

		if (scenario != null)
			addedArguments.Add($"scenario={scenario.ToSnakeCase()}");

		return addedArguments;
	}
}