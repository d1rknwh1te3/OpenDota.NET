namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc />
public class ParsedMatchesEndpoint(Requester requester) : IParsedMatchesEndpoint
{
	public Task<ParsedMatch?> GetParsedMatches(long lessThenMatchId) =>
		requester.GetResponseAsync<ParsedMatch>(
			"parsedMatches",
			[$"less_then_match_id={lessThenMatchId}"]);
}