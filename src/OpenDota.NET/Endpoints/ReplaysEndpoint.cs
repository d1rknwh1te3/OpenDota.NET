namespace OpenDotaDotNet.Endpoints;

public class ReplaysEndpoint(Requester requester) : IReplaysEndpoint
{
	/// <summary>
	/// Get data to construct a replay URL with.
	/// </summary>
	/// <param name="matchIds">Match IDs (array).</param>
	/// <returns>Data to construct a replay URL with.</returns>
	public Task<IEnumerable<Replay>?> GetReplayDataAsync(IEnumerable<long> matchIds) =>
		requester.GetResponseAsync<IEnumerable<Replay>>(
			"replays",
			matchIds?.Select(matchId => $"match_id={matchId}"));
}