using OpenDotaDotNet.Routes.ParsedMatches.Models;

namespace OpenDotaDotNet.Routes.ParsedMatches;

/// <inheritdoc />
public class ParsedMatchesEndpoint(Requester requester) : IParsedMatchesEndpoint
{
	/// <inheritdoc />
	public Task<ParsedMatch?> GetParsedMatchesAsync(long lessThenMatchId) =>
		requester.GetResponseAsync<ParsedMatch>(
			"parsedMatches",
			[$"less_then_match_id={lessThenMatchId}"]);
}