namespace OpenDota.NET.Tests.EndpointsTests;

public class HealthEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetServiceHealthData()
	{
		var health = await _openDotaApi.Health.GetServiceHealthDataAsync();
		testOutputHelper.WriteLine(health.ToJsonString());

		if (health != null)
		{
			Assert.True(health.CassandraUsage.Timestamp > 0);
			Assert.True(health.GcDelay.Timestamp > 0);
			Assert.True(health.ParseDelay.Timestamp > 0);
			Assert.True(health.PostgresUsage.Timestamp > 0);
			Assert.True(health.RedisUsage.Timestamp > 0);
			Assert.True(health.SeqNumDelay.Timestamp > 0);
			Assert.True(health.CassandraUsage.Threshold > 0);
			Assert.True(health.GcDelay.Threshold > 0);
			Assert.True(health.ParseDelay.Threshold > 0);
			Assert.True(health.PostgresUsage.Threshold > 0);
			Assert.True(health.RedisUsage.Threshold > 0);
			Assert.True(health.SeqNumDelay.Threshold > 0);
			Assert.True(health.CassandraUsage.Metric >= 0);
			Assert.True(health.GcDelay.Metric >= 0);
			Assert.True(health.ParseDelay.Metric >= 0);
			Assert.True(health.PostgresUsage.Metric >= 0);
			Assert.True(health.RedisUsage.Metric >= 0);
			Assert.True(health.SeqNumDelay.Metric <= 0);
		}
		else
		{
			Assert.Null(health);
		}
	}
}