namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Explorer endpoint.
/// </summary>
public interface IExplorerEndpoint
{
	public Task<JObject?> GetFromExplorerAsync(string query);
}