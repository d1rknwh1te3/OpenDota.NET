using OpenDotaDotNet.Routes.Matches.Models;

namespace OpenDotaDotNet.Routes.Matches;

/// <inheritdoc />
public class MatchesEndpoint(Requester requester) : IMatchesEndpoint
{
	/// <inheritdoc />
	public Task<Match?> GetMatchByIdAsync(long matchId) =>
		requester.GetResponseAsync<Match>($"matches/{matchId}");
}