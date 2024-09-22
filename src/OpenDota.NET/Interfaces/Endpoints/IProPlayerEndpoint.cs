namespace OpenDotaDotNet.Interfaces.Endpoints;

public interface IProPlayerEndpoint
{
	/// <summary>
	/// Get list of pro players.
	/// </summary>
	/// <returns>List of pro players.</returns>
	Task<IEnumerable<ProPlayer>?> GetProPlayersAsync();
}