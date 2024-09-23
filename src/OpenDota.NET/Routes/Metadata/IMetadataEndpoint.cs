namespace OpenDotaDotNet.Routes.Metadata;

/// <summary>
/// Metadata endpoint.
/// </summary>
public interface IMetadataEndpoint
{
	/// <summary>
	/// Gets site metadata.
	/// </summary>
	/// <returns>Site metadata.</returns>
	Task<Models.Metadata?> GetMetadataAsync();
}