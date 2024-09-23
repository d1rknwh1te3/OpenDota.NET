namespace OpenDotaDotNet.Routes.ProMatches;

/// <summary>
/// Represents pro matches endpoint.
/// </summary>
public interface IProMatchEndpoint
{
	/// <summary>
	/// Get list of pro matches.
	/// </summary>
	/// <param name="lessThanMatchId">Get matches with a match ID lower than this value.</param>
	/// <returns>List of pro matches.</returns>
	Task<IEnumerable<ProMatch>?> GetProMatchesAsync(long? lessThanMatchId = null);
}