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
			var first = result.First();

			Assert.True(first.Id > 0);
			Assert.True(first.Legs >= 0);
			Assert.True(first.Roles.Any());

			Assert.True(first.BaseHealth > 0);
			Assert.True(first.BaseHealthRegen is null or > 0);
			Assert.True(first.BaseMana > 0);
			Assert.True(first.BaseManaRegen >= 0);
			Assert.True(first.BaseArmor >= -3);
			Assert.True(first.BaseMr > 0);
			Assert.True(first.BaseAttackMin > 0);
			Assert.True(first.BaseAttackMax > 0);
			Assert.True(first.BaseStrength > 0);
			Assert.True(first.BaseAgility >= 0);
			Assert.True(first.BaseIntelligence > 0);
			Assert.True(first.StrengthGain > 0);
			Assert.True(first.AgilityGain >= 0);
			Assert.True(first.IntelligenceGain > 0);
			Assert.True(first.AttackRange > 0);
			Assert.True(first.ProjectileSpeed >= 0);
			Assert.True(first.AttackRate > 0);
			Assert.True(first.MoveSpeed > 0);
			Assert.True(first.TurnRate is null or > 0);
			Assert.True(first.ProPick > 0);
			Assert.True(first.ProWin > 0);
			Assert.True(first.ProBan > 0);
			Assert.True(first.HeraldPicks > 0);
			Assert.True(first.HeraldWins > 0);
			Assert.True(first.GuardianPicks > 0);
			Assert.True(first.GuardianWins > 0);
			Assert.True(first.CrusaderPicks > 0);
			Assert.True(first.CrusaderWins > 0);
			Assert.True(first.ArchonPicks > 0);
			Assert.True(first.ArchonWins > 0);
			Assert.True(first.LegendPicks > 0);
			Assert.True(first.LegendWins > 0);
			Assert.True(first.AncientPicks > 0);
			Assert.True(first.AncientWins > 0);
			Assert.True(first.DivinePicks > 0);
			Assert.True(first.DivineWins > 0);
			Assert.True(first.ImmortalPicks > 0);
			Assert.True(first.ImmortalWins > 0);

			Assert.False(string.IsNullOrWhiteSpace(first.Name));
			Assert.False(string.IsNullOrWhiteSpace(first.LocalizedName));
			Assert.False(string.IsNullOrWhiteSpace(first.Image));
			Assert.False(string.IsNullOrWhiteSpace(first.Icon));
		}
	}
}