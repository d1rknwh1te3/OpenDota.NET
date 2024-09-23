namespace OpenDotaDotNet.Endpoints;

/// <inheritdoc />
public class HealthEndpoint(Requester requester) : IHealthEndpoint
{
	/// <inheritdoc />
	public Task<ServiceHealth?> GetServiceHealthDataAsync() =>
		requester.GetResponseAsync<ServiceHealth>("health");
}