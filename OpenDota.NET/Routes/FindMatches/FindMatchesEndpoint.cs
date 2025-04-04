﻿namespace OpenDotaDotNet.Routes.FindMatches;

/// <inheritdoc />
public class FindMatchesEndpoint(Requester requester) : IFindMatchesEndpoint
{
	/// <inheritdoc />
	public Task<List<FindMatch>?> FindMatchesByHeroesPlayedAsync(
		List<int>? teamA = null,
		List<int>? teamB = null) =>
		requester.GetResponseAsync<List<FindMatch>>(
			"findMatches",
			GetArguments(teamA, teamB));

	private List<string> GetArguments(
		List<int>? teamA = null,
		List<int>? teamB = null)
	{
		var addedArguments = new List<string>();

		if (teamA != null)
			addedArguments.AddRange(teamA.Select(heroId => $"teamA={heroId}"));

		if (teamB != null)
			addedArguments.AddRange(teamB.Select(heroId => $"teamB={heroId}"));

		return addedArguments;
	}
}