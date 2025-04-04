namespace OpenDotaDotNet.Routes.Scenarios;

/// <summary>
/// Represents scenarios endpoint.
/// </summary>
public interface IScenariosEndpoint
{
	/// <summary>
	/// Gets win rates for certain item timings on a hero for items that cost at least 1400 gold. GET /scenarios/itemTimings.
	/// </summary>
	/// <param name="item">Filter by item name e.g. "spirit_vessel".</param>
	/// <param name="heroId">Hero ID.</param>
	/// <returns>Win rates for certain item timings on a hero for items that cost at least 1400 gold.</returns>
	Task<List<ItemTiming>?> GetItemNamingAsync(string? item = null, int? heroId = null);

	/// <summary>
	/// Gets win rates for heroes in certain lane roles. GET /scenarios/laneRoles.
	/// </summary>
	/// <param name="laneRole">Filter by lane role 1-4 (Safe, Mid, Off, Jungle).</param>
	/// <param name="heroId">Hero ID.</param>
	/// <returns>Win rates for heroes in certain lane roles.</returns>
	Task<List<LaneRoles>?> GetLaneRolesAsync(int? laneRole = null, int? heroId = null);

	/// <summary>
	/// Gets miscellaneous team scenarios. GET /scenarios/misc.
	/// </summary>
	/// <param name="scenario">Example value: pos_chat_1min, neg_chat_1min, courier_kill, first_blood.</param>
	/// <returns>Miscellaneous team scenarios.</returns>
	Task<List<TeamScenario>?> GetMiscTeamScenariosAsync(Scenario? scenario = null);
}