using OpenDotaDotNet.Routes.Teams.Models;

namespace OpenDota.NET.Tests.EndpointsTests;

public class TeamsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetTeams()
	{
		var result = await _openDotaApi.Teams.GetTeamsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var teams = result as Team[] ?? result.ToArray();

			Assert.Equal(1000, teams.Length);
			Assert.Contains(teams, x => !string.IsNullOrEmpty(x.Name));
			Assert.True(Array.TrueForAll(teams, x => x.Name != null));
			Assert.Contains(teams, x => !string.IsNullOrEmpty(x.Tag));
			Assert.True(Array.TrueForAll(teams, x => x.Tag != null));
			Assert.True(Array.TrueForAll(teams, x => x.TeamId > 0));
			Assert.True(Array.TrueForAll(teams, x => x.Wins > 0));
			Assert.True(Array.TrueForAll(teams, x => x.Losses >= 0));
			Assert.True(Array.TrueForAll(teams, x => x.LastMatchTime > 0));
			Assert.True(Array.TrueForAll(teams, x => x.Rating > 0));
			Assert.Contains(teams, x => !string.IsNullOrEmpty(x.LogoUrl?.ToString()));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetTeamById()
	{
		var result = await _openDotaApi.Teams.GetTeamByIdAsync(7554697);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal("Nigma Galaxy", result.Name);
			Assert.Equal("NGX", result.Tag);
			Assert.True(result.TeamId > 0);
			Assert.True(result.Wins > 0);
			Assert.True(result.Losses > 0);
			Assert.True(result.LastMatchTime > 0);
			Assert.True(result.Rating > 0);
			Assert.False(string.IsNullOrWhiteSpace(result.LogoUrl.ToString()));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task GetTeamByIdShouldReturnNullForTeamsThatAreNotFound()
	{
		var result = await _openDotaApi.Teams.GetTeamByIdAsync(1);
		Assert.Null(result);
	}

	[Fact]
	public async Task TestGetOgTeamMatchesById()
	{
		var result = await _openDotaApi.Teams.GetTeamMatchesByIdAsync(2586976); // OG
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var teamMatches = result as TeamMatch[] ?? result.ToArray();

			Assert.True(teamMatches.Length > 800);
			Assert.True(Array.TrueForAll(teamMatches, x => x.MatchId > 0));
			Assert.True(Array.TrueForAll(teamMatches, x => x.Duration > 0));
			Assert.True(Array.TrueForAll(teamMatches, x => x.StartTime > 0));
			Assert.True(Array.TrueForAll(teamMatches, x => x.Leagueid > 0));
			Assert.True(Array.TrueForAll(teamMatches, x => !string.IsNullOrEmpty(x.LeagueName)));
			Assert.True(Array.TrueForAll(teamMatches, x => x.Cluster > 0));
			Assert.True(Array.TrueForAll(teamMatches, x => x.OpposingTeamId > 0));
			Assert.Contains(teamMatches, x => !string.IsNullOrEmpty(x.OpposingTeamLogo?.ToString()));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetTeamPlayersById()
	{
		var result = await _openDotaApi.Teams.GetTeamPlayersByIdAsync(7554697);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var teamPlayers = result as TeamPlayer[] ?? result.ToArray();

			Assert.Equal(7, teamPlayers.Count(x => x.IsCurrentTeamMember == true));
			//Assert.Contains(teamPlayers, x => x.Name == "KuroKy"); TODO: Fix names
			//Assert.Contains(teamPlayers, x => x.Name == "GH");
			//Assert.Contains(teamPlayers, x => x.Name == "Miracle-");
			//Assert.Contains(teamPlayers, x => x.Name == "MinD_ContRoL");
			//Assert.Contains(teamPlayers, x => x.Name == "Yuma");
			Assert.True(Array.TrueForAll(teamPlayers, x => x.GamesPlayed >= 0));
			Assert.True(Array.TrueForAll(teamPlayers, x => x.Wins >= 0));
			Assert.True(Array.TrueForAll(teamPlayers, x => x.AccountId > 0));
		}
		else
		{
			Assert.Fail();
		}
	}

	[Fact]
	public async Task TestGetTeamSecretTeamHeroesById()
	{
		var result = await _openDotaApi.Teams.GetTeamHeroesByIdAsync(1838315); // Secret
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var teamHeroes = result as TeamHero[] ?? result.ToArray();

			Assert.True(teamHeroes.Length >= 119);
			Assert.True(Array.TrueForAll(teamHeroes, x => x.HeroId > 0));
			Assert.True(Array.TrueForAll(teamHeroes, x => x.GamesPlayed > 0));
			Assert.True(Array.TrueForAll(teamHeroes, x => x.Wins > 0));
			Assert.True(Array.TrueForAll(teamHeroes, x => !string.IsNullOrEmpty(x.LocalizedName)));
		}
		else
		{
			Assert.Fail();
		}
	}
}