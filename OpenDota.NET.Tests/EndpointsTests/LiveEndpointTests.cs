namespace OpenDota.NET.Tests.EndpointsTests;

public class LiveEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetTopLiveGames()
	{
		var result = await _openDotaApi.Live.GetTopLiveGamesAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			Assert.Equal(100, result.Count);
			Assert.True(result.TrueForAll(x => !string.IsNullOrWhiteSpace(x.LobbyId)));
			Assert.True(result.TrueForAll(x => x.Players.Count >= 0));
		}
	}
}