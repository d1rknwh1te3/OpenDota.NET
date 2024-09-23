namespace OpenDotaDotNet.Routes.Records;

/// <summary>
/// Records endpoint.
/// </summary>
public interface IRecordsEndpoint
{
	/// <summary>
	/// Get records in ranked matches. Records reset monthly.
	/// </summary>
	/// <param name="field">Field name to query.</param>
	/// <returns>Records in ranked matches.</returns>
	Task<IEnumerable<Record>?> GetRecordsByFieldAsync(Field field);
}