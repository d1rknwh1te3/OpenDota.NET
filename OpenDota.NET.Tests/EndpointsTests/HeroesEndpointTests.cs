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
			Assert.True(result.Count >= 119);
			Assert.True(result.TrueForAll(x => x.Roles.Count > 0));
			Assert.True(result.TrueForAll(x => x.Id > 0));
			Assert.True(result.TrueForAll(x => x.Legs >= 0));
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.LocalizedName)));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetHeroDurations()
	{
		var result = await _openDotaApi.Heroes.GetHeroDurationsAsync(1);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.TrueForAll(x => x.GamesPlayed > 0));
			Assert.True(result.TrueForAll(x => x.DurationBin > 0));
			Assert.True(result.TrueForAll(x => x.Wins >= 0));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetHeroMatches()
	{
		var result = await _openDotaApi.Heroes.GetHeroMatchesAsync(2);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(100, result.Count);
			Assert.True(result.TrueForAll(x => x.MatchId > 0));
			Assert.True(result.TrueForAll(x => x.StartTime > 0));
			Assert.True(result.TrueForAll(x => x.Duration > 0));
			Assert.True(result.TrueForAll(x => x.LeagueId > 0));
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.LeagueName)));
			Assert.True(result.TrueForAll(x => x.PlayerSlot >= 0));
			Assert.True(result.TrueForAll(x => x.AccountId > 0));
			Assert.True(result.TrueForAll(x => x.Kills >= 0));
			Assert.True(result.TrueForAll(x => x.Deaths >= 0));
			Assert.True(result.TrueForAll(x => x.Assists >= 0));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetHeroMatchups()
	{
		var result = await _openDotaApi.Heroes.GetHeroMatchupsAsync(3);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.Count >= 118);
			Assert.True(result.TrueForAll(x => x.HeroId > 0));
			Assert.True(result.TrueForAll(x => x.GamesPlayed > 0));
			Assert.True(result.TrueForAll(x => x.Wins > 0));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetHeroPlayers()
	{
		var result = await _openDotaApi.Heroes.GetHeroPlayersAsync(4);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.Count >= 1000);
			Assert.Contains(result, x => x.AccountId > 0);
			Assert.True(result.TrueForAll(x => x.GamesPlayed > 0));
			Assert.True(result.TrueForAll(x => x.Wins >= 0));
		}
		else
		{
			Assert.Fail();
		}
	}
}