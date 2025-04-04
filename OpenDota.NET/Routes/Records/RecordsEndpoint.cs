namespace OpenDotaDotNet.Routes.Records;

/// <inheritdoc />
public class RecordsEndpoint(Requester requester) : IRecordsEndpoint
{
	/// <inheritdoc />
	public Task<List<Record>?> GetRecordsByFieldAsync(Field field) =>
		requester.GetResponseAsync<List<Record>>($"records/{field.ToSnakeCase()}");
}