namespace OpenDotaDotNet.Endpoints;

public class ProMatchesEndpoint(Requester requester) : IProMatchEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<ProMatch>?> GetProMatchesAsync(long? lessThanMatchId = null) =>
		requester.GetResponseAsync<IEnumerable<ProMatch>>(
			"proMatches",
			GetArguments(lessThanMatchId));

	private static IEnumerable<string> GetArguments(long? lessThanMatchId = null)
	{
		var addedArguments = new List<string>();
		
		if (lessThanMatchId != null)
			addedArguments.Add($"less_than_match_id={lessThanMatchId}");

		return addedArguments;
	}
}