namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents match player benchmarks.
/// </summary>
public class MatchPlayerBenchmarks
{
	/// <summary>
	/// Gets a dictionary with gold per minute
	/// </summary>
	[JsonPropertyName("gold_per_min")]
	public Dictionary<string, double> GoldPerMin { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with xp per minute
	/// </summary>
	[JsonPropertyName("xp_per_min")]
	public Dictionary<string, double> XpPerMin { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with kills per minute
	/// </summary>
	[JsonPropertyName("kills_per_min")]
	public Dictionary<string, double> KillsPerMin { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with last hits per minute
	/// </summary>
	[JsonPropertyName("last_hits_per_min")]
	public Dictionary<string, double> LastHitsPerMin { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with hero damage per minute
	/// </summary>
	[JsonPropertyName("hero_damage_per_min")]
	public Dictionary<string, double> HeroDamagePerMin { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with hero healing per minute
	/// </summary>
	[JsonPropertyName("hero_healing_per_min")]
	public Dictionary<string, double> HeroHealingPerMin { get; init; } = new();
	
	/// <summary>
	/// Gets a dictionary with tower damage
	/// </summary>
	[JsonPropertyName("tower_damage")]
	public Dictionary<string, double> TowerDamage { get; init; } = new();

	/// <summary>
	/// Gets a dictionary with stuns per minute
	/// </summary>
	[JsonPropertyName("stuns_per_min")]
	public Dictionary<string, double> StunsPerMin { get; init; } = new();
	
	/// <summary>
	/// Gets a dictionary with 
	/// </summary>
	[JsonPropertyName("lhten")]
	public Dictionary<string, double> Lhten { get; init; } = new();
}