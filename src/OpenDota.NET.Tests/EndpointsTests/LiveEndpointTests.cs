namespace OpenDota.NET.Tests.EndpointsTests;

public class LiveEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetTopLiveGames()
	{
		var result = await _openDotaApi.Live.GetTopLiveGamesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.Equal(100, result.Count());
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.LobbyId)));
		Assert.True(result.All(x => x.Players.Any()));
	}
}