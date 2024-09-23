namespace OpenDotaDotNet.Routes.Distributions;

/// <inheritdoc />
public class DistributionsEndpoint(Requester requester) : IDistributionsEndpoint
{
	/// <inheritdoc />
	public Task<Distribution?> GetDistributionsAsync() =>
		requester.GetResponseAsync<Distribution>("distributions");
}