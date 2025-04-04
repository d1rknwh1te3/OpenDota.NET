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
			Assert.True(result.TrueForAll(x => x.AccountId > 0));
			Assert.True(result.Any(x => !string.IsNullOrWhiteSpace(x.Name)));
			Assert.True(result.Any(x => !string.IsNullOrWhiteSpace(x.SteamId)));
			Assert.True(result.Any(x => !string.IsNullOrWhiteSpace(x.PersonaName)));
		}
	}
}