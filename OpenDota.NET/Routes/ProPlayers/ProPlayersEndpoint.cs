namespace OpenDotaDotNet.Routes.ProPlayers;

/// <inheritdoc />
public class ProPlayersEndpoint(Requester requester) : IProPlayersEndpoint
{
	/// <inheritdoc />
	public Task<List<ProPlayer>?> GetProPlayersAsync() =>
		requester.GetResponseAsync<List<ProPlayer>>("proPlayers");
}