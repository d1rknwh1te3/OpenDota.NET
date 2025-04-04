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
	public Task<List<PlayerRecentMatch>?> GetPlayerRecentMatchesAsync(long accountId) =>
		requester.GetResponseAsync<List<PlayerRecentMatch>>($"players/{accountId}/recentMatches");

	/// <inheritdoc />
	public Task<List<PlayerMatch>?> GetPlayerMatchesAsync(
		long accountId,
		PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerMatch>>(
			$"players/{accountId}/matches",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<List<PlayerHero>?> GetPlayerHeroesAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerHero>>(
			$"players/{accountId}/heroes",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<List<PlayerPeer>?> GetPlayerPeersAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerPeer>>(
			$"players/{accountId}/peers",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<List<PlayerPro>?> GetPlayerProsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerPro>>(
			$"players/{accountId}/pros",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<List<PlayerTotal>?> GetPlayerTotalsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerTotal>>(
			$"players/{accountId}/totals",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<PlayerCount?> GetPlayerCountsAsync(long accountId, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<PlayerCount>(
			$"players/{accountId}/counts",
			GetArguments(parameters));

	/// <inheritdoc />
	public Task<List<PlayerHistogram>?> GetPlayerHistogramsAsync(long accountId, string field, PlayerEndpointParameters? parameters = null) =>
		requester.GetResponseAsync<List<PlayerHistogram>>(
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
	public Task<List<PlayerRating>?> GetPlayerRatingsAsync(long accountId) =>
		requester.GetResponseAsync<List<PlayerRating>>($"players/{accountId}/ratings");

	/// <inheritdoc />
	public Task<List<PlayerHeroRanking>?> GetPlayerHeroRankingsAsync(long accountId) =>
		requester.GetResponseAsync<List<PlayerHeroRanking>>($"players/{accountId}/rankings");

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