namespace OpenDota.NET.Tests.EndpointsTests;

public class PlayersEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetPlayerById()
	{
		var result = await _openDotaApi.Players.GetPlayerByIdAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null) 
			Assert.Equal(34505203, result.Profile.AccountId);
	}

	[Fact]
	public async Task TestGetPlayerWinLossById()
	{
		var result = await _openDotaApi.Players.GetPlayerWinLossByIdAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.Wins > 0);
			Assert.True(result.Losses > 0);
		}
	}

	[Fact]
	public async Task TestGetPlayerRecentMatches()
	{
		var result = await _openDotaApi.Players.GetPlayerRecentMatchesAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var recentMatches = result as PlayerRecentMatch[] ?? result.ToArray();

			Assert.True(recentMatches.Length > 0);
			Assert.True(Array.TrueForAll(recentMatches,x => x.MatchId > 0));
		}
	}

	[Fact]
	public async Task TestGetPlayerMatches()
	{
		var result = await _openDotaApi.Players.GetPlayerMatchesAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var matches = result as PlayerMatch[] ?? result.ToArray();

			Assert.True(matches.Length > 0);
			Assert.True(Array.TrueForAll(matches, x => x.MatchId > 0));
		}
	}

	[Fact]
	public async Task TestGetPlayerHeroes()
	{
		var result = await _openDotaApi.Players.GetPlayerHeroesAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var playerHeroes = result as PlayerHero[] ?? result.ToArray();

			Assert.True(playerHeroes.Length > 0);
			Assert.True(Array.TrueForAll(playerHeroes, x => x.HeroId > 0));
		}
	}

	[Fact]
	public async Task TestGetPlayerPeers()
	{
		var result = await _openDotaApi.Players.GetPlayerPeersAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var playerPeers = result as PlayerPeer[] ?? result.ToArray();

			Assert.True(playerPeers.Length > 0);
			Assert.True(Array.TrueForAll(playerPeers, x => x.AccountId > 0));
		}
	}

	[Fact]
	public async Task TestGetPlayerPros()
	{
		var result = await _openDotaApi.Players.GetPlayerProsAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var playerPros = result as PlayerPro[] ?? result.ToArray();

			Assert.True(playerPros.Length > 0);
			Assert.True(Array.TrueForAll(playerPros, x => x.AccountId > 0));
		}
	}

	[Fact]
	public async Task TestGetPlayerTotals()
	{
		var result = await _openDotaApi.Players.GetPlayerTotalsAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var playerTotals = result as PlayerTotal[] ?? result.ToArray();

			Assert.True(playerTotals.Length > 0);
			Assert.True(Array.TrueForAll(playerTotals, x => !string.IsNullOrWhiteSpace(x.Field)));
		}
	}

	[Fact]
	public async Task TestGetPlayerCounts()
	{
		var result = await _openDotaApi.Players.GetPlayerCountsAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.GameMode.Count > 0);
		Assert.True(result.IsRadiant.Count > 0);
		Assert.True(result.LaneRole.Count > 0);
		Assert.True(result.LeaverStatus.Count > 0);
		Assert.True(result.LobbyType.Count > 0);
		Assert.True(result.Patch.Count > 0);
		Assert.True(result.Region.Count > 0);
	}

	[Fact]
	public async Task TestGetPlayerHistograms()
	{
		var result = await _openDotaApi.Players.GetPlayerHistogramsAsync(34505203, "comeback");
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var histograms = result as PlayerHistogram[] ?? result.ToArray();

			Assert.True(histograms.Length > 0);
		}
	}

	[Fact]
	public async Task TestGetPlayerWardMap()
	{
		var result = await _openDotaApi.Players.GetPlayerWardMapAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());
	
		Assert.True(result is { Obs.Count: > 0 });
	}

	[Fact]
	public async Task TestGetPlayerWordCloud()
	{
		var result = await _openDotaApi.Players.GetPlayerWordCloudAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result is { AllWordCounts.Count: > 0 });
	}

	[Fact]
	public async Task TestGetPlayerRatings()
	{
		var result = await _openDotaApi.Players.GetPlayerRatingsAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var ratings = result as PlayerRating[] ?? result.ToArray();

			if (ratings.Length > 0)
			{
				Assert.True(Array.TrueForAll(ratings, x => x.AccountId > 0));
			}
		}
	}

	[Fact]
	public async Task TestGetPlayerHeroRankings()
	{
		var result = await _openDotaApi.Players.GetPlayerHeroRankingsAsync(34505203);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var heroRankings = result as PlayerHeroRanking[] ?? result.ToArray();

			Assert.True(heroRankings.Length > 0);
		}
	}
}