namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Represents a parsed matches endpoint.
/// </summary>
public interface IParsedMatchesEndpoint
{
	public Task<ParsedMatch?> GetParsedMatches(long lessThenMatchId);
}