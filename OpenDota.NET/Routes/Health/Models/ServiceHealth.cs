namespace OpenDotaDotNet.Routes.Health.Models;

/// <summary>
/// Represents a service health.
/// </summary>
public class ServiceHealth
{
	/// <summary>
	/// Gets or sets the posgres usage.
	/// </summary>
	[JsonPropertyName("postgresUsage")]
	public ServiceUsage PostgresUsage { get; set; }

	/// <summary>
	/// Gets or sets the cassandra usage.
	/// </summary>
	[JsonPropertyName("cassandraUsage")]
	public ServiceUsage CassandraUsage { get; set; }

	/// <summary>
	/// Gets or sets the parse delay.
	/// </summary>
	[JsonPropertyName("parseDelay")]
	public ServiceUsage ParseDelay { get; set; }

	/// <summary>
	/// Gets or sets the Redis usage.
	/// </summary>
	[JsonPropertyName("redisUsage")]
	public ServiceUsage RedisUsage { get; set; }

	[JsonPropertyName("seqNumDelay")]
	public ServiceUsage SeqNumDelay { get; set; }

	[JsonPropertyName("gcDelay")]
	public ServiceUsage GcDelay { get; set; }

	[JsonPropertyName("fhDelay")]
	public ServiceUsage FhDelay { get; set; }

	[JsonPropertyName("mmrDelay")]
	public ServiceUsage MmrDelay { get; set; }

	[JsonPropertyName("cacheDelay")]
	public ServiceUsage CacheDelay { get; set; }

	[JsonPropertyName("countsDelay")]
	public ServiceUsage CountsDelay { get; set; }

	[JsonPropertyName("scenariosDelay")]
	public ServiceUsage ScenariosDelay { get; set; }

}