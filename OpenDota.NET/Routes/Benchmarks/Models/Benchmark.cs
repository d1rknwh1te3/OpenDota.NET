﻿namespace OpenDotaDotNet.Routes.Benchmarks.Models;

/// <summary>
/// Represents a benchmark.
/// </summary>
public class Benchmark
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public long HeroId { get; set; }

	/// <summary>
	/// Gets or sets the result.
	/// </summary>
	[JsonPropertyName("result")]
	public BenchmarkResult? Result { get; set; }
}