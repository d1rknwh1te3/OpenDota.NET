namespace OpenDotaDotNet.Endpoints;

public class RecordsEndpoint(Requester requester) : IRecordsEndpoint
{
	/// <inheritdoc />
	public Task<IEnumerable<Record>?> GetRecordsByFieldAsync(RecordField field) =>
		requester.GetResponseAsync<IEnumerable<Record>>($"records/{field.Value}");
}