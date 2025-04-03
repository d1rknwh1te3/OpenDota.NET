namespace OpenDotaDotNet.Routes.Constants;

/// <inheritdoc />
public class ConstantsEndpoint(Requester requester) : IConstantsEndpoint
{
	/// <inheritdoc />
	public Task<JsonObject?> GetConstantsAsync(Constant resource) =>
		requester.GetResponseAsync<JsonObject>($"constants/{resource.ToSnakeCase()}");

	/// <inheritdoc />
	public Task<IEnumerable<string>?> GetConstantsAsync() =>
		requester.GetResponseAsync<IEnumerable<string>>("constants");
}