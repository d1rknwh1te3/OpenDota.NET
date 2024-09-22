namespace OpenDotaDotNet.Endpoints;

public class MatchesEndpoint(Requester requester) : IMatchesEndpoint
{
	/// <inheritdoc />
	public Task<Match?> GetMatchByIdAsync(long matchId) =>
		requester.GetResponseAsync<Match>($"matches/{matchId}");
}