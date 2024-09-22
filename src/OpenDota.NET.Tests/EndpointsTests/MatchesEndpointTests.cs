namespace OpenDota.NET.Tests.EndpointsTests;

public class MatchesEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetMatchById()
	{
		var result = await _openDotaApi.Matches.GetMatchByIdAsync(4986133311);
		testOutputHelper.WriteLine(result.ToJsonString());
	}
}