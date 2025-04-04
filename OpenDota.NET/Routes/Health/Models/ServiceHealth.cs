namespace OpenDotaDotNet.Routes.Health.Models;

/// <summary>
/// Represents a service health.
/// </summary>
public class ServiceHealth
{
	/// <summary>
	/// Gets the cache delay.
	/// </summary>
	[JsonPropertyName("cacheDelay")]
	public ServiceUsage? CacheDelay { get; init; }

	/// <summary>
	/// Gets the cassandra usage.
	/// </summary>
	[JsonPropertyName("cassandraUsage")]
	public ServiceUsage? CassandraUsage { get; init; }

	/// <summary>
	/// Gets the counts delay.
	/// </summary>
	[JsonPropertyName("countsDelay")]
	public ServiceUsage? CountsDelay { get; init; }

	/// <summary>
	/// Gets the FH delay.
	/// </summary>
	[JsonPropertyName("fhDelay")]
	public ServiceUsage? FhDelay { get; init; }

	/// <summary>
	/// Gets the GC delay.
	/// </summary>
	[JsonPropertyName("gcDelay")]
	public ServiceUsage? GcDelay { get; init; }

	/// <summary>
	/// Gets the MMR delay.
	/// </summary>
	[JsonPropertyName("mmrDelay")]
	public ServiceUsage? MmrDelay { get; init; }

	/// <summary>
	/// Gets the parse delay.
	/// </summary>
	[JsonPropertyName("parseDelay")]
	public ServiceUsage? ParseDelay { get; init; }

	/// <summary>
	/// Gets the posgres usage.
	/// </summary>
	[JsonPropertyName("postgresUsage")]
	public ServiceUsage? PostgresUsage { get; init; }
	/// <summary>
	/// Gets the Redis usage.
	/// </summary>
	[JsonPropertyName("redisUsage")]
	public ServiceUsage? RedisUsage { get; init; }

	/// <summary>
	/// Gets the scenarios delay.
	/// </summary>
	[JsonPropertyName("scenariosDelay")]
	public ServiceUsage? ScenariosDelay { get; init; }
	
	/// <summary>
	/// Gets the SEQ num delay.
	/// </summary>
	[JsonPropertyName("seqNumDelay")]
	public ServiceUsage? SeqNumDelay { get; init; }
}