namespace OpenDotaDotNet.Routes.Search;

/// <inheritdoc />
public class SearchEndpoint(Requester requester) : ISearchEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<PlayerResponse>?> GetPlayersByNameAsync(string personaName) =>
		requester.GetResponseAsync<IEnumerable<PlayerResponse>>(
			"search",
			[$"q={personaName}"]);
}