namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Metadata endpoint.
/// </summary>
public interface IMetadataEndpoint
{
	/// <summary>
	/// Gets site metadata.
	/// </summary>
	/// <returns>Site metadata.</returns>
	Task<Metadata?> GetMetadataAsync();
}