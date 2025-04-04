namespace OpenDotaDotNet.Routes.League;

/// <inheritdoc />
public class LeagueEndpoint(Requester requester) : ILeagueEndpoint
{
	/// <inheritdoc />
	public Task<List<Models.League>?> GetLeaguesAsync() =>
		requester.GetResponseAsync<List<Models.League>>("leagues");
}