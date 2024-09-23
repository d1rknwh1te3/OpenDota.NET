namespace OpenDota.NET.Tests.EndpointsTests;

public class DistributionsEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetDistributions()
	{
		var result = await _openDotaApi.Distributions.GetDistributionsAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.NotNull(result);
		}
	}
}