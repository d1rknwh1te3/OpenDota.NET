namespace OpenDotaDotNet.Routes.League;

/// <inheritdoc />
public class LeagueEndpoint(Requester requester) : ILeagueEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Models.League>?> GetLeaguesAsync() =>
		requester.GetResponseAsync<IEnumerable<Models.League>>("leagues");
}