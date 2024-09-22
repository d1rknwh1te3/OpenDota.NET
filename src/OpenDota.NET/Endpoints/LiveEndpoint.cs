namespace OpenDotaDotNet.Endpoints;

public class LiveEndpoint(Requester requester) : ILiveEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<LiveGame>?> GetTopLiveGamesAsync() =>
		requester.GetResponseAsync<IEnumerable<LiveGame>>("live");
}