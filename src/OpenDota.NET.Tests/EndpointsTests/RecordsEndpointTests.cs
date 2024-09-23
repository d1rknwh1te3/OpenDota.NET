using Record = OpenDotaDotNet.Models.Records.Record;

namespace OpenDota.NET.Tests.EndpointsTests;

public class RecordsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetRecordsByField()
	{
		var result = await _openDotaApi.Records.GetRecordsByFieldAsync(RecordField.Duration);
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var records = result as Record[] ?? result.ToArray();

			Assert.Equal(100, records.Length);
			Assert.True(Array.TrueForAll(records, x => x.MatchId > 0));
			Assert.True(Array.TrueForAll(records, x => x.Score > 0));
			Assert.True(Array.TrueForAll(records, x => x.StartTime > 0));
		}
	}
}