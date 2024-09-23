namespace OpenDotaDotNet.Routes.Metadata;

/// <inheritdoc />
public class MetadataEndpoint(Requester requester) : IMetadataEndpoint
{
	/// <inheritdoc />
	public Task<Models.Metadata?> GetMetadataAsync() =>
		requester.GetResponseAsync<Models.Metadata>("metadata");
}