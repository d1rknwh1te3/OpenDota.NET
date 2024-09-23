namespace OpenDotaDotNet.Routes.Constants;

/// <inheritdoc />
public class ConstantsEndpoint(Requester requester) : IConstantsEndpoint
{
	/// <inheritdoc />
	public Task<JObject?> GetConstantsAsync(Constant resource) =>
		requester.GetResponseAsync<JObject>($"constants/{resource.ToSnakeCase()}");

	/// <inheritdoc />
	public Task<IEnumerable<string>?> GetConstantsAsync() =>
		requester.GetResponseAsync<IEnumerable<string>>("constants");
}