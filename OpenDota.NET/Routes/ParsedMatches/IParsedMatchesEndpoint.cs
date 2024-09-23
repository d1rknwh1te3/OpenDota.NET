namespace OpenDotaDotNet.Routes.ParsedMatches;

/// <summary>
/// Represents a parsed matches endpoint.
/// </summary>
public interface IParsedMatchesEndpoint
{
	public Task<ParsedMatch?> GetParsedMatchesAsync(long lessThenMatchId);
}