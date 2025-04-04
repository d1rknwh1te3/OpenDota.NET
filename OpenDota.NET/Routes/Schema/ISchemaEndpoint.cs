namespace OpenDotaDotNet.Routes.Schema;

/// <summary>
/// Schema endpoint.
/// </summary>
public interface ISchemaEndpoint
{
	/// <summary>
	/// Get database schema.
	/// </summary>
	/// <returns>Database schema.</returns>
	Task<List<DatabaseSchema>?> GetDatabaseSchemaAsync();
}