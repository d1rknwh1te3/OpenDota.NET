namespace OpenDotaDotNet.Endpoints;

public class ScenariosEndpoint(Requester requester) : IScenariosEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<HeroItemTiming>?> GetWinRateForCertainItemTimingsOnHeroesAsync(string? item = null, int? heroId = null) =>
		requester.GetResponseAsync<IEnumerable<HeroItemTiming>>(
			"scenarios/itemTimings",
			GetArguments(item, heroId));

	/// <inheritdoc />
	public Task<IEnumerable<HeroLaneRoleWinrate>?> GetWinRateForHeroesInCertainLaneRolesAsync(int? laneRole = null, int? heroId = null) =>
		requester.GetResponseAsync<IEnumerable<HeroLaneRoleWinrate>>(
			"scenarios/laneRoles",
			GetArguments(null, heroId, laneRole));

	/// <inheritdoc />
	public Task<IEnumerable<MiscellaneousTeamScenario>?> GetMiscellaneousTeamScenariosAsync(string? scenario = null) =>
		requester.GetResponseAsync<IEnumerable<MiscellaneousTeamScenario>>(
			"scenarios/misc",
			GetArguments(null, null, null, scenario));

	private List<string> GetArguments(string? item = null, int? heroId = null, int? laneRole = null, string? scenario = null)
	{
		var addedArguments = new List<string>();

		if (item != null) 
			addedArguments.Add($"item={item}");

		if (heroId != null) 
			addedArguments.Add($"hero_id={heroId}");

		if (laneRole != null) 
			addedArguments.Add($"lane_role={laneRole}");

		if (scenario != null) 
			addedArguments.Add($"scenario={scenario}");

		return addedArguments;
	}
}