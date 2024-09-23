using OpenDotaDotNet.Routes.Search.Models;

namespace OpenDota.NET.Tests.EndpointsTests;

public class SearchEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetPlayersByName()
	{
		var result = await _openDotaApi.Search.GetPlayersByNameAsync("mind_control");
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null)
		{
			var playerResponses = result as PlayerResponse[] ?? result.ToArray();

			Assert.Equal(50, playerResponses.Length);

			Assert.Contains(playerResponses, x => x.LastMatchTime > new DateTime(2000, 1, 1));

			Assert.True(Array.TrueForAll(playerResponses, x => x.AccountId > 0));
			Assert.True(Array.TrueForAll(playerResponses, x => x.Similarity > 0));
			Assert.True(Array.TrueForAll(playerResponses, x => !x.LastMatchTime.HasValue || x.LastMatchTime > new DateTime(2000, 1, 1)));
			Assert.True(Array.TrueForAll(playerResponses, x => !string.IsNullOrWhiteSpace(x.PersonaName)));
			Assert.True(Array.TrueForAll(playerResponses, x => !string.IsNullOrWhiteSpace(x.AvatarFull.ToString())));
		}
	}
}