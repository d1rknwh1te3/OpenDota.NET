namespace OpenDotaDotNet.Endpoints;

public class SchemaEndpoint(Requester requester) : ISchemaEndpoint
{
	/// <summary>
	/// Get database schema.
	/// </summary>
	/// <returns>Database schema.</returns>
	public Task<IEnumerable<DatabaseSchema>?> GetDatabaseSchemaAsync() =>
		requester.GetResponseAsync<IEnumerable<DatabaseSchema>>("schema");
}