namespace OpenDota.NET.Tests.EndpointsTests;

public class SchemaEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly OpenDotaApi _openDotaApi = new();

	[Fact]
	public async Task TestGetDatabaseSchema()
	{
		var result = await _openDotaApi.Schema.GetDatabaseSchemaAsync();
		testOutputHelper.WriteLine(result.ToJsonString());

		var schema = result as DatabaseSchema[] ?? result.ToArray();

		//Assert.True(schema.Length >= 335); TODO: Fix schema length
		Assert.True(Array.TrueForAll(schema, x => x.ColumnName != null && x.DataType != null && x.TableName != null));
	}
}