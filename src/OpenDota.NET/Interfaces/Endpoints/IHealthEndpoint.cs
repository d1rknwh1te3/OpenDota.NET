namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Health endpoint.
/// </summary>
public interface IHealthEndpoint
{
	/// <summary>
	/// Get service health data.
	/// </summary>
	/// <returns>Service health data.</returns>
	Task<ServiceHealth?> GetServiceHealthDataAsync();
}