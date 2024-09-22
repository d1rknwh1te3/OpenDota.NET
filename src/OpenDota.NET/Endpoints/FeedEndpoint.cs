namespace OpenDotaDotNet.Endpoints;

public class FeedEndpoint(Requester requester) : IFeedEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ProMatch>?> GetFeedAsync(
		long? sequenceNumber = null,
		int? gameMode = null,
		int? leagueId = null,
		long? includedAccountId = null) =>
		requester.GetResponseAsync<IEnumerable<ProMatch>>(
			"feed",
			GetArguments(sequenceNumber, gameMode, leagueId, includedAccountId));

	private List<string> GetArguments(
		long? sequenceNumber = null,
		int? gameMode = null,
		int? leagueId = null,
		long? includedAccountId = null)
	{
		var addedArguments = new List<string>();
		
		if (sequenceNumber != null) 
			addedArguments.Add($"sequenceNumber={sequenceNumber}");

		if (gameMode != null)
			addedArguments.Add($"gameMode={gameMode}");

		if (leagueId != null) 
			addedArguments.Add($"leagueId={leagueId}");

		if (includedAccountId != null) 
			addedArguments.Add($"includedAccountId={includedAccountId}");

		return addedArguments;
	}
}