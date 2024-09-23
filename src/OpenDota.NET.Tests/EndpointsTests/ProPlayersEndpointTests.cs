using OpenDotaDotNet.Routes.ProPlayers.Models;

namespace OpenDota.NET.Tests.EndpointsTests;

public class ProPlayersEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetProPlayers()
	{
		var result = await _openDotaApi.ProPlayers.GetProPlayersAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var proPlayers = result as ProPlayer[] ?? result.Take(30).ToArray();

			Assert.True(Array.TrueForAll(proPlayers, x => x.AccountId > 0));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.SteamId)));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.PersonaName)));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.Avatar.ToString())));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.AvatarMedium.ToString())));
			Assert.True(Array.TrueForAll(proPlayers, x => !string.IsNullOrWhiteSpace(x.AvatarFull.ToString())));
		}
	}
}