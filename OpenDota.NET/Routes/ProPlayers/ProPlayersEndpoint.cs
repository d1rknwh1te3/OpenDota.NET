namespace OpenDotaDotNet.Routes.ProPlayers;

/// <inheritdoc />
public class ProPlayersEndpoint(Requester requester) : IProPlayersEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ProPlayer>?> GetProPlayersAsync() =>
		requester.GetResponseAsync<IEnumerable<ProPlayer>>("proPlayers");
}