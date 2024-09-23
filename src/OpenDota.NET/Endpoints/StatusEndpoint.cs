namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc />
public class StatusEndpoint(Requester requester) : IStatusEndpoint
{
	/// <inheritdoc />
	public Task<ServiceStatistics?> GetServiceStatisticsAsync() =>
		requester.GetResponseAsync<ServiceStatistics>("status");
}