namespace OpenDotaDotNet.Interfaces.Endpoints;

public interface IReplaysEndpoint
{
	/// <summary>
	/// Get data to construct a replay URL with.
	/// </summary>
	/// <param name="matchIds">Match IDs (array).</param>
	/// <returns>Data to construct a replay URL with.</returns>
	Task<IEnumerable<Replay>?> GetReplayDataAsync(IEnumerable<long> matchIds);
}