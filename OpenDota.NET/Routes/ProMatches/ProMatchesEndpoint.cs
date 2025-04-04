namespace OpenDotaDotNet.Routes.ProMatches;

/// <inheritdoc />
public class ProMatchesEndpoint(Requester requester) : IProMatchEndpoint
{
	/// <inheritdoc />
	public Task<List<ProMatch>?> GetProMatchesAsync(long? lessThanMatchId = null) =>
		requester.GetResponseAsync<List<ProMatch>>(
			"proMatches",
			GetArguments(lessThanMatchId));

	private static List<string> GetArguments(long? lessThanMatchId = null)
	{
		var addedArguments = new List<string>();

		if (lessThanMatchId != null)
			addedArguments.Add($"less_than_match_id={lessThanMatchId}");

		return addedArguments;
	}
}