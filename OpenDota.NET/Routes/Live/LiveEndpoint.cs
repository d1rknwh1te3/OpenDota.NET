namespace OpenDotaDotNet.Routes.Live;

/// <inheritdoc />
public class LiveEndpoint(Requester requester) : ILiveEndpoint
{
	/// <inheritdoc />
	public Task<List<LiveGame>?> GetTopLiveGamesAsync() =>
		requester.GetResponseAsync<List<LiveGame>>("live");
}