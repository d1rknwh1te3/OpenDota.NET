using OpenDotaDotNet.Routes.PublicMatches.Models;

namespace OpenDotaDotNet.Routes.PublicMatches;

public class PublicMatchesEndpoint(Requester requester) : IPublicMatchesEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<PublicMatch>?> GetPublicMatchesAsync(
		int? mmrAscending = null,
		int? mmrDescending = null,
		long? lessThanMatchId = null) =>
		requester.GetResponseAsync<IEnumerable<PublicMatch>>(
			"publicMatches",
			GetArguments(mmrAscending, mmrDescending, lessThanMatchId));

	private static List<string> GetArguments(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null)
	{
		var addedArguments = new List<string>();

		if (mmrAscending != null)
			addedArguments.Add($"mmr_ascending={mmrAscending}");

		if (mmrDescending != null)
			addedArguments.Add($"mmr_descending={mmrDescending}");

		if (lessThanMatchId != null)
			addedArguments.Add($"less_than_match_id={lessThanMatchId}");

		return addedArguments;
	}
}