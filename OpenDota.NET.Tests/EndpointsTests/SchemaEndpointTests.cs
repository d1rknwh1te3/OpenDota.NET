namespace OpenDota.NET.Tests.EndpointsTests;

public class SchemaEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetDatabaseSchema()
	{
		var result = await _openDotaApi.Schema.GetDatabaseSchemaAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		if (result != null) 
			Assert.Contains(result, x => x.TableName == "api_key_usage");
	}
}