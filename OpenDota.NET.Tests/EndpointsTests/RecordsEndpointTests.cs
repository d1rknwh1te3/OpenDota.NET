using Record = OpenDotaDotNet.Routes.Records.Models.Record;

namespace OpenDota.NET.Tests.EndpointsTests;

public class RecordsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetRecordsByField()
	{
		var result = await _openDotaApi.Records.GetRecordsByFieldAsync(Field.Duration);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(100, result.Count);
			Assert.True(result.TrueForAll(x => x.MatchId > 0));
			Assert.True(result.TrueForAll(x => x.Score > 0));
			Assert.True(result.TrueForAll(x => x.StartTime > 0));
		}
	}
}