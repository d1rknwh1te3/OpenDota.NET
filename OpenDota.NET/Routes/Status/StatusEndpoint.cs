namespace OpenDotaDotNet.Routes.Status;

/// <inheritdoc />
public class StatusEndpoint(Requester requester) : IStatusEndpoint
{
	/// <inheritdoc />
	public Task<ServiceStatistics?> GetServiceStatisticsAsync() =>
		requester.GetResponseAsync<ServiceStatistics>("status");
}