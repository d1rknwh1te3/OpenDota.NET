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
	Task<IEnumerable<DatabaseSchema>?> GetDatabaseSchemaAsync();
}