namespace OpenDotaDotNet.Models.HealthStatus;

public class ServiceHealth
{
	[JsonProperty("postgresUsage")]
	public ServiceUsage PostgresUsage { get; set; }

	[JsonProperty("cassandraUsage")]
	public ServiceUsage CassandraUsage { get; set; }

	[JsonProperty("parseDelay")]
	public ServiceUsage ParseDelay { get; set; }

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