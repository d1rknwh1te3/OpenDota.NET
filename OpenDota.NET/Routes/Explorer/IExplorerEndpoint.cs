namespace OpenDotaDotNet.Routes.Explorer;

/// <summary>
/// Represents an explorer endpoint.
/// </summary>
public interface IExplorerEndpoint
{
	/// <summary>
	/// Submit arbitrary SQL queries to the database.
	/// </summary>
	/// <param name="query">The PostgreSQL query as percent-encoded string.</param>
	/// <returns>Explorer response in JObject format.</returns>
	public Task<JObject?> GetFromExplorerAsync(string query);
}