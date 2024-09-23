using League = OpenDotaDotNet.Routes.League.Models.League;

namespace OpenDotaDotNet.Routes.League;

public class LeagueEndpoint(Requester requester) : ILeagueEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<League>?> GetLeaguesAsync() =>
		requester.GetResponseAsync<IEnumerable<League>>("leagues");
}