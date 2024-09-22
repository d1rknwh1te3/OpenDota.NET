namespace OpenDotaDotNet.Endpoints;

public class TeamsEndpoint(Requester requester) : ITeamsEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Team>?> GetTeamsAsync() =>
		requester.GetResponseAsync<IEnumerable<Team>>("teams");

	/// <inheritdoc />
	public Task<Team?> GetTeamByIdAsync(int teamId) =>
		requester.GetResponseAsync<Team>($"teams/{teamId}");

	/// <inheritdoc />
	public Task<IEnumerable<TeamMatch>?> GetTeamMatchesByIdAsync(int teamId) =>
		requester.GetResponseAsync<IEnumerable<TeamMatch>>($"teams/{teamId}/matches");

	/// <inheritdoc />
	public Task<IEnumerable<TeamPlayer>?> GetTeamPlayersByIdAsync(int teamId) =>
		requester.GetResponseAsync<IEnumerable<TeamPlayer>>($"teams/{teamId}/players");

	/// <inheritdoc />
	public Task<IEnumerable<TeamHero>?> GetTeamHeroesByIdAsync(int teamId) =>
		requester.GetResponseAsync<IEnumerable<TeamHero>>($"teams/{teamId}/heroes");
}