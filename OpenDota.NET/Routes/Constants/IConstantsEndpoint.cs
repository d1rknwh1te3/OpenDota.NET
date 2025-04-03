namespace OpenDotaDotNet.Routes.Constants;

/// <summary>
/// Constants endpoint.
/// </summary>
public interface IConstantsEndpoint
{
	/// <summary>
	/// Get static game data mirrored from the dotaconstants repository. Get /constants/{resource}
	/// </summary>
	/// <param name="resource">The resource.</param>
	/// <returns></returns>
	public Task<JsonObject?> GetConstantsAsync(Constant resource);

	/// <summary>
	/// Gets an array of available resources. GET /constants
	/// </summary>
	/// <returns></returns>
	public Task<IEnumerable<string>?> GetConstantsAsync();

}