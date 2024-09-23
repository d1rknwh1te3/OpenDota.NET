namespace OpenDotaDotNet.Routes.Explorer;

/// <inheritdoc />
public class ExplorerEndpoint(Requester requester) : IExplorerEndpoint
{
	/// <inheritdoc />
	public Task<JObject?> GetFromExplorerAsync(string query) =>
		requester.GetResponseAsync<JObject>(
			"explorer",
			[$"sql={query}"]);
}