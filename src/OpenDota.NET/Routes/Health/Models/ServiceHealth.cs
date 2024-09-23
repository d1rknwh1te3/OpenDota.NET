namespace OpenDotaDotNet.Routes.Health.Models;

/// <summary>
/// Represents a service health.
/// </summary>
public class ServiceHealth
{
	/// <summary>
	/// Gets or sets the posgres usage.
	/// </summary>
	[JsonProperty("postgresUsage")]
	public ServiceUsage PostgresUsage { get; set; }

	/// <summary>
	/// Gets or sets the cassandra usage.
	/// </summary>
	[JsonProperty("cassandraUsage")]
	public ServiceUsage CassandraUsage { get; set; }

	/// <summary>
	/// Gets or sets the parse delay.
	/// </summary>
	[JsonProperty("parseDelay")]
	public ServiceUsage ParseDelay { get; set; }

	/// <summary>
	/// Gets or sets the Redis usage.
	/// </summary>
	[JsonProperty("redisUsage")]
	public ServiceUsage RedisUsage { get; set; }

	[JsonProperty("seqNumDelay")]
	public ServiceUsage SeqNumDelay { get; set; }

	[JsonProperty("gcDelay")]
	public ServiceUsage GcDelay { get; set; }

	[JsonProperty("fhDelay")]
	public ServiceUsage FhDelay { get; set; }

	[JsonProperty("mmrDelay")]
	public ServiceUsage MmrDelay { get; set; }

	[JsonProperty("cacheDelay")]
	public ServiceUsage CacheDelay { get; set; }

	[JsonProperty("countsDelay")]
	public ServiceUsage CountsDelay { get; set; }

	[JsonProperty("scenariosDelay")]
	public ServiceUsage ScenariosDelay { get; set; }

}