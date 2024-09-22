namespace OpenDota.NET.Tests.EndpointsTests;

public class RecordsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetRecordsByField()
	{
		var result = await _openDotaApi.Records.GetRecordsByFieldAsync(RecordField.Duration);
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.Equal(100, result.Count());
		Assert.True(result.All(x => x.MatchId > 0));
		Assert.True(result.All(x => x.Score > 0));
		Assert.True(result.All(x => x.StartTime > 0));
	}
}