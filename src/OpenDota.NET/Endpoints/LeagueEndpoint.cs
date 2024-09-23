using League = OpenDotaDotNet.Models.Leagues.League;

namespace OpenDotaDotNet.Endpoints;

public class LeagueEndpoint(Requester requester) : ILeagueEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<League>?> GetLeaguesAsync() =>
		requester.GetResponseAsync<IEnumerable<League>>("leagues");
}