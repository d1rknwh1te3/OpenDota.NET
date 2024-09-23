namespace OpenDota.NET.Tests.EndpointsTests;

public class HeroesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetHeroes()
	{
		var result = await _openDotaApi.Heroes.GetHeroesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var heroes = result as Hero[] ?? result.ToArray();

			Assert.True(heroes.Length >= 119);
			Assert.True(Array.TrueForAll(heroes, x => x.Roles.Any()));
			Assert.True(Array.TrueForAll(heroes, x => x.Id > 0));
			Assert.True(Array.TrueForAll(heroes, x => x.Legs >= 0));
			Assert.True(Array.TrueForAll(heroes, x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.True(Array.TrueForAll(heroes, x => !string.IsNullOrWhiteSpace(x.LocalizedName)));
		}
	}

	[Fact]
	public async Task TestGetHeroDurations()
	{
		var result = await _openDotaApi.Heroes.GetHeroDurationsAsync(1);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var durations = result as HeroDuration[] ?? result.ToArray();

			Assert.True(Array.TrueForAll(durations, x => x.GamesPlayed > 0));
			Assert.True(Array.TrueForAll(durations, x => x.DurationBin > 0));
			Assert.True(Array.TrueForAll(durations, x => x.Wins >= 0));
		}
	}

	[Fact]
	public async Task TestGetHeroMatches()
	{
		var result = await _openDotaApi.Heroes.GetHeroMatchesAsync(2);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var matches = result as HeroMatch[] ?? result.ToArray();

			Assert.Equal(100, matches.Length);
			Assert.True(Array.TrueForAll(matches, x => x.MatchId > 0));
			Assert.True(Array.TrueForAll(matches, x => x.StartTime > 0));
			Assert.True(Array.TrueForAll(matches, x => x.Duration > 0));
			Assert.True(Array.TrueForAll(matches, x => x.LeagueId > 0));
			Assert.True(Array.TrueForAll(matches, x => !string.IsNullOrWhiteSpace(x.LeagueName)));
			Assert.True(Array.TrueForAll(matches, x => x.PlayerSlot >= 0));
			Assert.True(Array.TrueForAll(matches, x => x.AccountId > 0));
			Assert.True(Array.TrueForAll(matches, x => x.Kills >= 0));
			Assert.True(Array.TrueForAll(matches, x => x.Deaths >= 0));
			Assert.True(Array.TrueForAll(matches, x => x.Assists >= 0));
		}
	}

	[Fact]
	public async Task TestGetHeroMatchups()
	{
		var result = await _openDotaApi.Heroes.GetHeroMatchupsAsync(3);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var matchups = result as HeroMatchup[] ?? result.ToArray();

			Assert.True(matchups.Length >= 118);
			Assert.True(Array.TrueForAll(matchups, x => x.HeroId > 0));
			Assert.True(Array.TrueForAll(matchups, x => x.GamesPlayed > 0));
			Assert.True(Array.TrueForAll(matchups, x => x.Wins > 0));
		}
	}

	[Fact]
	public async Task TestGetHeroPlayers()
	{
		var result = await _openDotaApi.Heroes.GetHeroPlayersAsync(4);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var players = result as HeroPlayer[] ?? result.ToArray();

			Assert.True(players.Length >= 1000);
			Assert.Contains(players, x => x.AccountId > 0);
			Assert.True(Array.TrueForAll(players, x => x.GamesPlayed > 0));
			Assert.True(Array.TrueForAll(players, x => x.Wins >= 0));
		}
	}
}