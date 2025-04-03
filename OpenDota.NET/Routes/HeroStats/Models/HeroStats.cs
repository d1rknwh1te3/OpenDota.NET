namespace OpenDotaDotNet.Routes.HeroStats.Models;

/// <summary>
/// Represents hero stats.
/// </summary>
public class HeroStats
{
	/// <summary>
	/// Gets or sets numeric identifier for the hero object.
	/// </summary>
	[JsonPropertyName("id")]
	public required long Id { get; set; }

	/// <summary>
	/// Gets or sets dota hero command name, e.g. 'npc_dota_hero_antimage'.
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	/// <summary>
	/// Gets or sets hero name, e.g. 'Anti-Mage'.
	/// </summary>
	[JsonPropertyName("localized_name")]
	public required string LocalizedName { get; set; }

	/// <summary>
	/// Gets or sets hero primary shorthand attribute name, e.g. 'agi'.
	/// </summary>
	[JsonPropertyName("primary_attr")]
	public required HeroPrimaryAttribute PrimaryAttribute { get; set; }

	/// <summary>
	/// Gets or sets hero attack type, either 'Melee' or 'Ranged'.
	/// </summary>
	[JsonPropertyName("attack_type")]
	public required HeroAttackType AttackType { get; set; }

	/// <summary>
	/// Gets or sets hero's role in the game.
	/// </summary>
	[JsonPropertyName("roles")]
	public required IEnumerable<HeroRole> Roles { get; set; }

	/// <summary>
	/// Gets or sets the image.
	/// </summary>
	[JsonPropertyName("img")]
	public required string Image { get; set; }

	/// <summary>
	/// Gets or sets the icon.
	/// </summary>
	[JsonPropertyName("icon")]
	public required string Icon { get; set; }

	/// <summary>
	/// Gets or sets the base health.
	/// </summary>
	[JsonPropertyName("base_health")]
	public int BaseHealth { get; set; }

	/// <summary>
	/// Gets or sets the base health regen.
	/// </summary>
	[JsonPropertyName("base_health_regen")]
	public double? BaseHealthRegen { get; set; }

	[JsonPropertyName("base_mana")]
	public int BaseMana { get; set; }

	[JsonPropertyName("base_mana_regen")]
	public double BaseManaRegen { get; set; }

	[JsonPropertyName("base_armor")]
	public double BaseArmor { get; set; }

	[JsonPropertyName("base_mr")]
	public int BaseMr { get; set; }

	[JsonPropertyName("base_attack_min")]
	public int BaseAttackMin { get; set; }

	[JsonPropertyName("base_attack_max")]
	public int BaseAttackMax { get; set; }

	[JsonPropertyName("base_str")]
	public int BaseStrength { get; set; }

	[JsonPropertyName("base_agi")]
	public int BaseAgility { get; set; }

	[JsonPropertyName("base_int")]
	public int BaseIntelligence { get; set; }

	[JsonPropertyName("str_gain")]
	public double StrengthGain { get; set; }

	[JsonPropertyName("agi_gain")]
	public double AgilityGain { get; set; }

	[JsonPropertyName("int_gain")]
	public double IntelligenceGain { get; set; }

	[JsonPropertyName("attack_range")]
	public int AttackRange { get; set; }

	[JsonPropertyName("projectile_speed")]
	public int ProjectileSpeed { get; set; }

	[JsonPropertyName("attack_rate")]
	public double AttackRate { get; set; }

	[JsonPropertyName("attack_point")]
	public double AttackPoint { get; set; }

	[JsonPropertyName("move_speed")]
	public int MoveSpeed { get; set; }

	[JsonPropertyName("turn_rate")]
	public double? TurnRate { get; set; }

	[JsonPropertyName("cm_enabled")]
	public bool CmEnabled { get; set; }

	/// <summary>
	/// Gets or sets hero's amount of legs.
	/// </summary>
	[JsonPropertyName("legs")]
	public int Legs { get; set; }

	[JsonPropertyName("day_vision")]
	public int DayVision { get; set; }

	[JsonPropertyName("night_vision")]
	public int NightVision { get; set; }

	[JsonPropertyName("pro_ban")]
	public int ProBan { get; set; }

	[JsonPropertyName("pro_win")]
	public int ProWin { get; set; }

	[JsonPropertyName("pro_pick")]
	public int ProPick { get; set; }

	[JsonPropertyName("1_pick")]
	public int HeraldPicks { get; set; }

	[JsonPropertyName("1_win")]
	public int HeraldWins { get; set; }

	[JsonPropertyName("2_pick")]
	public int GuardianPicks { get; set; }

	[JsonPropertyName("2_win")]
	public int GuardianWins { get; set; }

	[JsonPropertyName("3_pick")]
	public int CrusaderPicks { get; set; }

	[JsonPropertyName("3_win")]
	public int CrusaderWins { get; set; }

	[JsonPropertyName("4_pick")]
	public int ArchonPicks { get; set; }

	[JsonPropertyName("4_win")]
	public int ArchonWins { get; set; }

	[JsonPropertyName("5_pick")]
	public int LegendPicks { get; set; }

	[JsonPropertyName("5_win")]
	public int LegendWins { get; set; }

	[JsonPropertyName("6_pick")]
	public int AncientPicks { get; set; }

	[JsonPropertyName("6_win")]
	public int AncientWins { get; set; }

	[JsonPropertyName("7_pick")]
	public int DivinePicks { get; set; }

	[JsonPropertyName("7_win")]
	public int DivineWins { get; set; }

	[JsonPropertyName("8_pick")]
	public int ImmortalPicks { get; set; }

	[JsonPropertyName("8_win")]
	public int ImmortalWins { get; set; }

	[JsonPropertyName("turbo_pick")]
	public int TurboPicks { get; set; }

	[JsonPropertyName("turbo_pick_trend")]
	public int[] TurboPicksTrend { get; set; }

	[JsonPropertyName("turbo_win")]
	public int TurboWins { get; set; }

	[JsonPropertyName("turbo_win_trend")]
	public int[] TurboWinsTrend { get; set; }

	[JsonPropertyName("pub_pick")]
	public int PubPicks { get; set; }

	[JsonPropertyName("pub_pick_trend")]
	public int[] PubPicksTrend { get; set; }

	[JsonPropertyName("pub_win")]
	public int PubWins { get; set; }

	[JsonPropertyName("pub_win_trend")]
	public int[] PubWinsTrend { get; set; }
}