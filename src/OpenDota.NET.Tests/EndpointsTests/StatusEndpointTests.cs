namespace OpenDota.NET.Tests.EndpointsTests;

public class StatusEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetServiceStatistics()
	{
		var result = await _openDotaApi.Status.GetServiceStatisticsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.True(result.UserPlayers > 0);
			Assert.True(result.UserPlayersRecent > 0);
			Assert.True(result.TrackedPlayers > 0);
			Assert.True(result.MatchesLastDay > 0);
			Assert.True(result.MatchesPrevHour > 0);
			Assert.True(result.RetrieverMatchesLastDay > 0);
			Assert.True(result.DistinctMatchPlayersLastDay > 0);
			Assert.True(result.DistinctMatchPlayersUserLastDay > 0);
			Assert.True(result.DistinctMatchPlayersRecentUserLastDay > 0);
			Assert.True(result.DistinctRequestsLastDay > 0);
			Assert.True(result.AutoParseLastDay > 0);
			Assert.True(result.RequestsLastDay > 0);
			Assert.True(result.RequestsUiDay > 0);
			Assert.True(result.RequestsApiKeyLastDay > 0);
			Assert.True(result.RegistryRetriever > 0);
			Assert.True(result.RegistryParser > 0);
			Assert.True(result.RetrieverMatchesCurrentHour > 0);
			Assert.True(result.RetrieverMatchesLastDay > 0);
			Assert.True(result.RetrieverPlayersLastDay > 0);
			Assert.True(result.ParseJobsLastDay > 0);
			Assert.True(result.ParseFailsLastDay > 0);
			Assert.True(result.ParseCrashesLastDay > 0);
			Assert.True(result.ParsedMatchesLastDay > 0);
			Assert.True(result.ReparseEarlyLastDay > 0);
			Assert.True(result.ReapiLastDay > 0);
			Assert.True(result.RegcdataLastDay > 0);
			Assert.True(result.ReparseLastDay > 0);
			Assert.True(result.OldparseLastDay > 0);
			Assert.True(result.FullhistoryLastDay > 0);
			Assert.True(result.FullhistoryShortLastDay > 0);
			Assert.True(result.FullhistoryOpsLastDay > 0);
			Assert.True(result.FullhistorySkipsLastDay > 0);
			Assert.True(result.SteamApiCallsLastDay > 0);
			Assert.True(result.SteamProxyCallsLastDay > 0);
			Assert.True(result.Steam429LastDay > 0);
			Assert.True(result.Steam403LastDay > 0);
			Assert.True(result.SteamApiBackfillLastDay > 0);
			Assert.True(result.SteamGcBackfillLastDay > 0);
			Assert.True(result.MatchArchiveReadLastDay > 0);
			Assert.True(result.MatchArchiveWriteLastDay > 0);
			Assert.True(result.IncompleteArchiveLastDay > 0);
			Assert.True(result.ApiHitsLastDay > 0);
			Assert.True(result.ApiHitsUiLastDay > 0);
			Assert.True(result.BuildMatchLastDay > 0);
			Assert.True(result.GetPlayerMatchesLastDay > 0);
			Assert.True(result.SelfPlayerMatchesLastDay > 0);
			Assert.True(result.MatchCacheHitLastDay > 0);
			Assert.True(result.PlayerCacheHitLastDay > 0);
			Assert.True(result.PlayerCacheMissLastDay > 0);
			Assert.True(result.PlayerCacheWaitLastDay > 0);
			Assert.True(result.PlayerCacheWriteLastDay > 0);
			Assert.True(result.DistinctPlayerCacheLastDay > 0);
			Assert.True(result.AutoPlayerCacheHitLastDay > 0);
			Assert.True(result.AutoPlayerCacheMissLastDay > 0);
			Assert.True(result.AutoPlayerCacheLastDay > 0);
			Assert.True(result.DistinctAutoPlayerCacheLastDay > 0);
			Assert.True(result.ErrorLastDay > 0);
			Assert.True(result.SecondaryScannerLastDay > 0);
		}
		else
		{
			Assert.Null(result);
		}
	}

	[Fact]
	public async Task TestGetServiceHealthData()
	{
		var result = await _openDotaApi.Status.GetServiceStatisticsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var health = result.Health;

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
			Assert.Null(result);
		}
	}

	[Fact]
	public async Task TestGetLoadTimes()
	{
		var result = await _openDotaApi.Status.GetServiceStatisticsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var times = result.LoadTimes;

			Assert.True(times.Count > 0);
		}
		else
		{
			Assert.Null(result);
		}
	}

	[Fact]
	public async Task TestGetApiStatus()
	{
		var result = await _openDotaApi.Status.GetServiceStatisticsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var apistatus = result.ApiStatus;

			Assert.True(apistatus.Any());
		}

		else
		{
			Assert.Null(result);
		}
	}
}