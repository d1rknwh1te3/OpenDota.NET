namespace OpenDotaDotNet.Routes.Constants;

/// <inheritdoc />
public class ConstantsEndpoint(Requester requester) : IConstantsEndpoint
{
	/// <inheritdoc />
	public Task<JsonObject?> GetConstantsAsync(Constant resource) =>
		requester.GetResponseAsync<JsonObject>($"constants/{resource.ToSnakeCase()}");

	/// <inheritdoc />
	public Task<List<string>?> GetConstantsAsync() =>
		requester.GetResponseAsync<List<string>>("constants");
}