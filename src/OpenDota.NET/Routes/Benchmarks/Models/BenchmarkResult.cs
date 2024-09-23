namespace OpenDotaDotNet.Routes.Benchmarks.Models;

/// <summary>
/// Benchmark result.
/// </summary>
public class BenchmarkResult
{
	/// <summary>
	/// Gets or sets the gold per minute benchmarks.
	/// </summary>
	[JsonProperty("gold_per_min")]
	public IEnumerable<BenchmarkValue> GoldPerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the experience per minute benchmarks.
	/// </summary>
	[JsonProperty("xp_per_min")]
	public IEnumerable<BenchmarkValue> XpPerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the kills per minute benchmarks.
	/// </summary>
	[JsonProperty("kills_per_min")]
	public IEnumerable<BenchmarkValue> KillsPerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the last hits per minute benchmarks.
	/// </summary>
	[JsonProperty("last_hits_per_min")]
	public IEnumerable<BenchmarkValue> LastHitPerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the hero damage per minute benchmarks.
	/// </summary>
	[JsonProperty("hero_damage_per_min")]
	public IEnumerable<BenchmarkValue> HeroDamagePerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the hero healing per minute benchmarks.
	/// </summary>
	[JsonProperty("hero_healing_per_min")]
	public IEnumerable<BenchmarkValue> HeroHealingPerMinutes { get; set; }

	/// <summary>
	/// Gets or sets the tower damage benchmarks.
	/// </summary>
	[JsonProperty("tower_damage")]
	public IEnumerable<BenchmarkValue> TowerDamage { get; set; }
}