namespace OpenDotaDotNet.Routes.Distributions;

/// <summary>
/// Distributions endpoint.
/// </summary>
public interface IDistributionsEndpoint
{
	/// <summary>
	/// Gets distributions of MMR data by bracket and country.
	/// </summary>
	/// <returns>Distributions of MMR data by bracket and country.</returns>
	Task<Distribution?> GetDistributionsAsync();
}