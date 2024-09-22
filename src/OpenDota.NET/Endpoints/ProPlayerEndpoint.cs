namespace OpenDotaDotNet.Endpoints;

public class ProPlayerEndpoint(Requester requester) : IProPlayerEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ProPlayer>?> GetProPlayersAsync() =>
		requester.GetResponseAsync<IEnumerable<ProPlayer>>("proPlayers");
}