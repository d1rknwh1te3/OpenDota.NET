namespace OpenDotaDotNet.Routes.Explorer;

/// <inheritdoc />
public class ExplorerEndpoint(Requester requester) : IExplorerEndpoint
{
	/// <inheritdoc />
	public Task<JsonObject?> GetFromExplorerAsync(string query) =>
		requester.GetResponseAsync<JsonObject>(
			"explorer",
			[$"sql={query}"]);
}