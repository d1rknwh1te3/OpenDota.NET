namespace OpenDotaDotNet.Endpoints;

public class MetadataEndpoint(Requester requester) : IMetadataEndpoint
{
	/// <inheritdoc />
	public Task<Metadata?> GetMetadataAsync() =>
		requester.GetResponseAsync<Metadata>("metadata");
}