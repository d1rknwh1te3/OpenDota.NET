namespace OpenDota.NET.Tests.EndpointsTests;

public class MetadataEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetMetadata()
	{
		var result = await _openDotaApi.Metadata.GetMetadataAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.True(result.Cheese.CheeseAmount > 0);
		Assert.True(result.Cheese.Goal > 0);
		Assert.True(result.Scenarios.ItemCost > 0);
		Assert.True(result.Scenarios.GameDurationBucket.Length > 0);
		Assert.True(result.Scenarios.TeamScenariosQueryParams.Length > 0);
		Assert.True(result.Scenarios.Timings.Length > 0);
	}
}