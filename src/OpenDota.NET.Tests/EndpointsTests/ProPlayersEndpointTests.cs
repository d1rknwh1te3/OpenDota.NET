namespace OpenDota.NET.Tests.EndpointsTests;

public class ProPlayersEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetProPlayers()
	{
		var result = await _openDotaApi.ProPlayers.GetProPlayersAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		Assert.Contains(result, x => x.Name == "MinD_ContRoL");
		Assert.True(result.All(x => x.SteamId != null));
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.Name)));
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.Avatar.ToString())));
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.AvatarMedium.ToString())));
		Assert.True(result.All(x => !string.IsNullOrEmpty(x.AvatarFull.ToString())));
		Assert.True(result.Count() >= 1000);
	}
}