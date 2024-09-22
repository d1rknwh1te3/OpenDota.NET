using OpenDotaDotNet.Models.HeroStats;

namespace OpenDota.NET.Tests.EndpointsTests;

public class HeroStatsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetHeroStats()
	{
		var result = await _openDotaApi.HeroStats.GetHeroStatsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var heroStats = result as HeroStats[] ?? result.ToArray();

			Assert.True(heroStats.Length >= 119);
			Assert.True(heroStats.All(x => x.Id > 0));
			Assert.True(heroStats.All(x => x.HeroId > 0));
			Assert.True(heroStats.All(x => x.Legs >= 0));
			Assert.True(heroStats.All(x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.True(heroStats.All(x => !string.IsNullOrWhiteSpace(x.LocalizedName)));
			Assert.True(heroStats.Count(x => x.AttackType == HeroAttackType.Melee) >= 57);
			Assert.True(heroStats.Count(x => x.AttackType == HeroAttackType.Ranged) >= 62);
			Assert.True(heroStats.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Agi) >= 37);
			Assert.True(heroStats.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Int) >= 43);
			Assert.True(heroStats.Count(x => x.PrimaryAttribute == HeroPrimaryAttribute.Str) >= 39);
			Assert.True(heroStats.All(x => x.Roles.Any()));
			Assert.True(heroStats.All(x => !string.IsNullOrWhiteSpace(x.Image)));
			Assert.True(heroStats.All(x => !string.IsNullOrWhiteSpace(x.Icon)));

			Assert.True(heroStats.All(x => x.BaseHealth > 0));
			Assert.True(heroStats.All(x => !x.BaseHealthRegen.HasValue || x.BaseHealthRegen > 0));
			Assert.True(heroStats.All(x => x.BaseMana > 0));
			Assert.True(heroStats.All(x => x.BaseManaRegen >= 0));
			Assert.True(heroStats.All(x => x.BaseArmor >= -3));
			Assert.True(heroStats.All(x => x.BaseMr > 0));
			Assert.True(heroStats.All(x => x.BaseAttackMin > 0));
			Assert.True(heroStats.All(x => x.BaseAttackMax > 0));
			Assert.True(heroStats.All(x => x.BaseStrength > 0));
			Assert.True(heroStats.All(x => x.BaseAgility >= 0));
			Assert.True(heroStats.All(x => x.BaseIntelligence > 0));
			Assert.True(heroStats.All(x => x.StrengthGain > 0));
			Assert.True(heroStats.All(x => x.AgilityGain >= 0));
			Assert.True(heroStats.All(x => x.IntelligenceGain > 0));
			Assert.True(heroStats.All(x => x.AttackRange > 0));
			Assert.True(heroStats.All(x => x.ProjectileSpeed >= 0));
			Assert.True(heroStats.All(x => x.AttackRate > 0));
			Assert.True(heroStats.All(x => x.MoveSpeed > 0));
			Assert.True(heroStats.All(x => x.TurnRate > 0));

			Assert.True(heroStats.All(x => x.ProPick > 0));
			Assert.True(heroStats.All(x => x.ProWin > 0));
			Assert.True(heroStats.All(x => x.ProBan > 0));
			Assert.True(heroStats.All(x => x.HeraldPicks > 0));
			Assert.True(heroStats.All(x => x.HeraldWins > 0));
			Assert.True(heroStats.All(x => x.GuardianPicks > 0));
			Assert.True(heroStats.All(x => x.GuardianWins > 0));
			Assert.True(heroStats.All(x => x.CrusaderPicks > 0));
			Assert.True(heroStats.All(x => x.CrusaderWins > 0));
			Assert.True(heroStats.All(x => x.ArchonPicks > 0));
			Assert.True(heroStats.All(x => x.ArchonWins > 0));
			Assert.True(heroStats.All(x => x.LegendPicks > 0));
			Assert.True(heroStats.All(x => x.LegendWins > 0));
			Assert.True(heroStats.All(x => x.AncientPicks > 0));
			Assert.True(heroStats.All(x => x.AncientWins > 0));
			Assert.True(heroStats.All(x => x.DivinePicks > 0));
			Assert.True(heroStats.All(x => x.DivineWins > 0));
			Assert.True(heroStats.All(x => x.ImmortalPicks > 0));
			Assert.True(heroStats.All(x => x.ImmortalWins > 0));
			Assert.True(heroStats.All(x => x.NullPicks > 0));
			Assert.True(heroStats.All(x => x.NullWins == 0));
		}
	}
}