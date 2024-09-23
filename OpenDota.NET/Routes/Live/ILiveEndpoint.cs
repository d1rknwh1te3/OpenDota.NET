namespace OpenDotaDotNet.Routes.Live;

/// <summary>
/// Live endpoint.
/// </summary>
public interface ILiveEndpoint
{
	/// <summary>
	/// Get top currently ongoing live games.
	/// </summary>
	/// <returns>Top currently ongoing live games.</returns>
	Task<IEnumerable<LiveGame>?> GetTopLiveGamesAsync();
}