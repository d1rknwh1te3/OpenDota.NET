namespace OpenDotaDotNet.Routes.ProPlayers;

/// <summary>
/// Represents pro players endpoint.
/// </summary>
public interface IProPlayersEndpoint
{
	/// <summary>
	/// Get list of pro players.
	/// </summary>
	/// <returns>List of pro players.</returns>
	Task<IEnumerable<ProPlayer>?> GetProPlayersAsync();
}