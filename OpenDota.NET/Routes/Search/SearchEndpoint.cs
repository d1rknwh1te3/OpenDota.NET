namespace OpenDotaDotNet.Routes.Search;

/// <inheritdoc />
public class SearchEndpoint(Requester requester) : ISearchEndpoint
{
	/// <inheritdoc />
	public Task<List<PlayerResponse>?> GetPlayersByNameAsync(string personaName) =>
		requester.GetResponseAsync<List<PlayerResponse>>(
			"search",
			[$"q={personaName}"]);
}