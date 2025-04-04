namespace OpenDotaDotNet.Routes.League;

/// <summary>
/// League endpoint.
/// </summary>
public interface ILeagueEndpoint
{
	/// <summary>
	/// Get league data.
	/// </summary>
	/// <returns>League data.</returns>
	Task<List<Models.League>?> GetLeaguesAsync();
}