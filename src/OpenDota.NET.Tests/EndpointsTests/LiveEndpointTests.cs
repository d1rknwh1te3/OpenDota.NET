using OpenDotaDotNet.Routes.Live.Models;

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
			var liveGames = result as LiveGame[] ?? result.ToArray();

			Assert.Equal(100, liveGames.Length);
			Assert.True(Array.TrueForAll(liveGames, x => !string.IsNullOrEmpty(x.LobbyId)));
			Assert.True(Array.TrueForAll(liveGames, x => x.Players.Any()));
		}
	}
}