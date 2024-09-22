namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Search endpoint.
/// </summary>
public interface ISearchEndpoint
{
	/// <summary>
	/// Search players by personaname.
	/// </summary>
	/// <param name="query">Search string.</param>
	/// <returns>Players by personaname.</returns>
	Task<IEnumerable<SearchPlayerResponse>?> GetPlayersByNameAsync(string query);
}