namespace OpenDotaDotNet.Routes.Matches;

/// <summary>
/// Matches endpoint.
/// </summary>
public interface IMatchesEndpoint
{
	/// <summary>
	/// Get match data by ID.
	/// </summary>
	/// <param name="matchId">ID used to identify individual matches, e.g. 3703866531.</param>
	/// <returns>Match data.</returns>
	Task<Match?> GetMatchByIdAsync(long matchId);
}