namespace OpenDotaDotNet.Endpoints;

public class DistributionsEndpoint(Requester requester) : IDistributionsEndpoint
{
	/// <inheritdoc />
	public Task<Distribution?> GetDistributionsAsync() =>
		requester.GetResponseAsync<Distribution>("distributions");
}