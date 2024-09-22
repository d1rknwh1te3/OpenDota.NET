namespace OpenDota.NET.Tests.EndpointsTests;

public class SearchEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetPlayersByName()
	{
		var result = await _openDotaApi.Search.GetPlayersByNameAsync("mind_control");
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.Equal(50, result.Count());
		Assert.True(result.All(x => x.AccountId > 0));
		Assert.True(result.All(x => x.Similarity > 0));
		Assert.Contains(result, x => x.LastMatchTime > new DateTime(2000, 1, 1));
		Assert.True(result.All(x => !x.LastMatchTime.HasValue || x.LastMatchTime > new DateTime(2000, 1, 1)));
		Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.PersonaName)));
		Assert.True(result.All(x => !string.IsNullOrWhiteSpace(x.AvatarFull.ToString())));
	}
}