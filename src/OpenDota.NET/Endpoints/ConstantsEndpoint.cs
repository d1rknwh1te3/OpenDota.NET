namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc /> TODO: complete implementation
public class ConstantsEndpoint(Requester requester) : IConstantsEndpoint
{
	public Task<JObject?> GetConstantsAsync(string resource) =>
		requester.GetResponseAsync<JObject>($"constants/{resource}");
}