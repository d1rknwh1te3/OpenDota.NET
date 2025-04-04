namespace OpenDotaDotNet.Routes.Schema;

public class SchemaEndpoint(Requester requester) : ISchemaEndpoint
{
	/// <summary>
	/// Get database schema.
	/// </summary>
	/// <returns>Database schema.</returns>
	public Task<List<DatabaseSchema>?> GetDatabaseSchemaAsync() =>
		requester.GetResponseAsync<List<DatabaseSchema>>("schema");
}