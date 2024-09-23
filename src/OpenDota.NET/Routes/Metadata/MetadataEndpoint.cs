namespace OpenDotaDotNet.Routes.Metadata;

public class MetadataEndpoint(Requester requester) : IMetadataEndpoint
{
	/// <inheritdoc />
	public Task<Models.Metadata?> GetMetadataAsync() =>
		requester.GetResponseAsync<Models.Metadata>("metadata");
}