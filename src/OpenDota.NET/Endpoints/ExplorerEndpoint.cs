namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc />
public class ExplorerEndpoint(Requester requester) : IExplorerEndpoint
{
	public Task<JObject?> GetFromExplorerAsync(string query) =>
		requester.GetResponseAsync<JObject>(
			"explorer", 
			[$"sql={query}"]);
}