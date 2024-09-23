namespace OpenDotaDotNet.Endpoints;

public class SearchEndpoint(Requester requester) : ISearchEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<SearchPlayerResponse>?> GetPlayersByNameAsync(string query) =>
		requester.GetResponseAsync<IEnumerable<SearchPlayerResponse>>(
			"search",
			[$"q={query}"]);
}