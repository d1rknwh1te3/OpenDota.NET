namespace OpenDotaDotNet.Models.HeroStats;

public class HeroStats
{
	/// <summary>
	/// Gets or sets numeric identifier for the hero object.
	/// </summary>
	[JsonProperty("id")]
	public required long Id { get; set; }

	/// <summary>
	/// Gets or sets dota hero command name, e.g. 'npc_dota_hero_antimage'.
	/// </summary>
	[JsonProperty("name")]
	public required string Name { get; set; }

	/// <summary>
	/// Gets or sets hero name, e.g. 'Anti-Mage'.
	/// </summary>
	[JsonProperty("localized_name")]
	public required string LocalizedName { get; set; }

	/// <summary>
	/// Gets or sets hero primary shorthand attribute name, e.g. 'agi'.
	/// </summary>
	[JsonProperty("primary_attr")]
	public required HeroPrimaryAttribute PrimaryAttribute { get; set; }

	/// <summary>
	/// Gets or sets hero attack type, either 'Melee' or 'Ranged'.
	/// </summary>
	[JsonProperty("attack_type")]
	public required HeroAttackType AttackType { get; set; }

	/// <summary>
	/// Gets or sets hero's role in the game.
	/// </summary>
	[JsonProperty("roles")]
	public required IEnumerable<HeroRole> Roles { get; set; }

	[JsonProperty("img")]
	public string Image { get; set; }

	[JsonProperty("icon")]
	public string Icon { get; set; }

	[JsonProperty("base_health")]
	public int BaseHealth { get; set; }

	[JsonProperty("base_health_regen")]
	public double? BaseHealthRegen { get; set; }

	[JsonProperty("base_mana")]
	public int BaseMana { get; set; }

	[JsonProperty("base_mana_regen")]
	public double BaseManaRegen { get; set; }

	[JsonProperty("base_armor")]
	public double BaseArmor { get; set; }

	[JsonProperty("base_mr")]
	public int BaseMr { get; set; }

	[JsonProperty("base_attack_min")]
	public int BaseAttackMin { get; set; }

	[JsonProperty("base_attack_max")]
	public int BaseAttackMax { get; set; }

	[JsonProperty("base_str")]
	public int BaseStrength { get; set; }

	[JsonProperty("base_agi")]
	public int BaseAgility { get; set; }

	[JsonProperty("base_int")]
	public int BaseIntelligence { get; set; }

	[JsonProperty("str_gain")]
	public double StrengthGain { get; set; }

	[JsonProperty("agi_gain")]
	public double AgilityGain { get; set; }

	[JsonProperty("int_gain")]
	public double IntelligenceGain { get; set; }

	[JsonProperty("attack_range")]
	public int AttackRange { get; set; }

	[JsonProperty("projectile_speed")]
	public int ProjectileSpeed { get; set; }

	[JsonProperty("attack_rate")]
	public double AttackRate { get; set; }

	[JsonProperty("move_speed")]
	public int MoveSpeed { get; set; }

	[JsonProperty("turn_rate")]
	public double TurnRate { get; set; }

	[JsonProperty("cm_enabled")]
	public bool CmEnabled { get; set; }

	/// <summary>
	/// Gets or sets hero's amount of legs.
	/// </summary>
	[JsonProperty("legs")]
	public int Legs { get; set; }

	[JsonProperty("pro_ban")]
	public int ProBan { get; set; }

	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	[JsonProperty("pro_win")]
	public int ProWin { get; set; }

	[JsonProperty("pro_pick")]
	public int ProPick { get; set; }

	[JsonProperty("1_pick")]
	public int HeraldPicks { get; set; }

	[JsonProperty("1_win")]
	public int HeraldWins { get; set; }

	[JsonProperty("2_pick")]
	public int GuardianPicks { get; set; }

	[JsonProperty("2_win")]
	public int GuardianWins { get; set; }

	[JsonProperty("3_pick")]
	public int CrusaderPicks { get; set; }

	[JsonProperty("3_win")]
	public int CrusaderWins { get; set; }

	[JsonProperty("4_pick")]
	public int ArchonPicks { get; set; }

	[JsonProperty("4_win")]
	public int ArchonWins { get; set; }

	[JsonProperty("5_pick")]
	public int LegendPicks { get; set; }

	[JsonProperty("5_win")]
	public int LegendWins { get; set; }

	[JsonProperty("6_pick")]
	public int AncientPicks { get; set; }

	[JsonProperty("6_win")]
	public int AncientWins { get; set; }

	[JsonProperty("7_pick")]
	public int DivinePicks { get; set; }

	[JsonProperty("7_win")]
	public int DivineWins { get; set; }

	[JsonProperty("8_pick")]
	public int ImmortalPicks { get; set; }

	[JsonProperty("8_win")]
	public int ImmortalWins { get; set; }

	[JsonProperty("null_pick")]
	public long NullPicks { get; set; }

	[JsonProperty("null_win")]
	public long NullWins { get; set; }
}