namespace OpenDotaDotNet.Routes.Records;

/// <inheritdoc />
public class RecordsEndpoint(Requester requester) : IRecordsEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Record>?> GetRecordsByFieldAsync(Field field) =>
		requester.GetResponseAsync<IEnumerable<Record>>($"records/{field.ToSnakeCase()}");
}