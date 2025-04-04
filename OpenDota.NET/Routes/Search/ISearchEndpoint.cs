namespace OpenDotaDotNet.Routes.Search;

/// <summary>
/// Represents search endpoint.
/// </summary>
public interface ISearchEndpoint
{
	/// <summary>
	/// Search players by PersonaName.
	/// </summary>
	/// <param name="personaName">Search string.</param>
	/// <returns>Players by PersonaName.</returns>
	Task<List<PlayerResponse>?> GetPlayersByNameAsync(string personaName);
}