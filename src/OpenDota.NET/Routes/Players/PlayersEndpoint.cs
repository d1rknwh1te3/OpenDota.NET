using OpenDotaDotNet.Routes.Players.Models;

namespace OpenDotaDotNet.Routes.Players;

/// <inheritdoc />
public class PlayersEndpoint(Requester requester) : IPlayersEndpoint
{
	/// <inheritdoc />
	public Task<Player?> GetPlayerByIdAsync(long accountId) =>
		requester.GetResponseAsync<Player>($"players/{accountId}");

	/// <inheritdoc />
	public Task<PlayerWinLoss?> GetPlayerWinLossByIdAsync(
		long accountId,
		PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<PlayerWinLoss>(
			$"players/{accountId}/wl",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerRecentMatch>?> GetPlayerRecentMatchesAsync(long accountId) =>
		requester.GetResponseAsync<IEnumerable<PlayerRecentMatch>>($"players/{accountId}/recentMatches");

	/// <inheritdoc />
	public Task<IEnumerable<PlayerMatch>?> GetPlayerMatchesAsync(
		long accountId,
		PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerMatch>>(
			$"players/{accountId}/matches",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerHero>?> GetPlayerHeroesAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerHero>>(
			$"players/{accountId}/heroes",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerPeer>?> GetPlayerPeersAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerPeer>>(
			$"players/{accountId}/peers",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerPro>?> GetPlayerProsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerPro>>(
			$"players/{accountId}/pros",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerTotal>?> GetPlayerTotalsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerTotal>>(
			$"players/{accountId}/totals",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<PlayerCount?> GetPlayerCountsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<PlayerCount>(
			$"players/{accountId}/counts",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerHistogram>?> GetPlayerHistogramsAsync(long accountId, string field, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<IEnumerable<PlayerHistogram>>(
			$"players/{accountId}/histograms/{field}",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<PlayerWardMap?> GetPlayerWardMapAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<PlayerWardMap>(
			$"players/{accountId}/wardmap",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<PlayerWordCloud?> GetPlayerWordCloudAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<PlayerWordCloud>(
			$"players/{accountId}/wordcloud",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<IEnumerable<PlayerRating>?> GetPlayerRatingsAsync(long accountId) =>
		requester.GetResponseAsync<IEnumerable<PlayerRating>>($"players/{accountId}/ratings");

	/// <inheritdoc />
	public Task<IEnumerable<PlayerHeroRanking>?> GetPlayerHeroRankingsAsync(long accountId) =>
		requester.GetResponseAsync<IEnumerable<PlayerHeroRanking>>($"players/{accountId}/rankings");

	/// <inheritdoc />
	public async Task<bool> RefreshPlayerMatchHistoryAsync(long accountId)
	{
		var response = await requester.PostRequestAsync($"players/{accountId}/refresh");
		response.EnsureSuccessStatusCode();

		return true;
	}

	private static List<string> GetArguments(PlayerEndpointParameters? parameters)
	{
		var addedArguments = new List<string>();

		if (parameters == null)
			return addedArguments;

		if (parameters.Limit != null)
			addedArguments.Add($"limit={parameters.Limit}");

		if (parameters.Offset != null)
			addedArguments.Add($"offset={parameters.Offset}");

		if (parameters.Win != null)
			addedArguments.Add($"win={parameters.Win}");

		if (parameters.Patch != null)
			addedArguments.Add($"patch={parameters.Patch}");

		if (parameters.GameMode != null)
			addedArguments.Add($"game_mode={parameters.GameMode}");

		if (parameters.LobbyType != null)
			addedArguments.Add($"lobby_type={parameters.LobbyType}");

		if (parameters.Region != null)
			addedArguments.Add($"region={parameters.Region}");

		if (parameters.Date != null)
			addedArguments.Add($"date={parameters.Date}");

		if (parameters.LaneRole != null)
			addedArguments.Add($"lane_role={parameters.LaneRole}");

		if (parameters.HeroId != null)
			addedArguments.Add($"hero_id={parameters.HeroId}");

		if (parameters.IsRadiant != null)
			addedArguments.Add($"is_radiant={parameters.IsRadiant}");

		if (parameters.IncludedAccountIds != null)
			addedArguments.AddRange(
				parameters.IncludedAccountIds.Select(
					includedAccountId => $"included_account_id={includedAccountId}"));

		if (parameters.ExcludedAccountIds != null)
			addedArguments.AddRange(
				parameters.ExcludedAccountIds.Select(
					excludedAccountId => $"excluded_account_id={excludedAccountId}"));

		if (parameters.WithHeroIds != null)
			addedArguments.AddRange(parameters.WithHeroIds.Select(withHeroId => $"with_hero_id={withHeroId}"));

		if (parameters.AgainstHeroIds != null)
			addedArguments.AddRange(parameters.AgainstHeroIds.Select(againstHeroId => $"against_hero_id={againstHeroId}"));

		if (parameters.Significant != null)
			addedArguments.Add($"significant={parameters.Significant}");

		if (parameters.Having != null)
			addedArguments.Add($"having={parameters.Having}");

		if (parameters.Sort != null)
			addedArguments.Add($"sort={parameters.Sort}");

		if (parameters.Project != null)
			addedArguments.AddRange(parameters.Project.Select(project => $"project={project}"));

		return addedArguments;
	}
}