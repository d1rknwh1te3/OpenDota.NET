namespace OpenDotaDotNet.Routes.ProPlayers;

public class ProPlayersEndpoint(Requester requester) : IProPlayersEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ProPlayer>?> GetProPlayersAsync() =>
		requester.GetResponseAsync<IEnumerable<ProPlayer>>("proPlayers");
}