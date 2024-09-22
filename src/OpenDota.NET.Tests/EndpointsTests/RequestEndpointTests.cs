namespace OpenDota.NET.Tests.EndpointsTests;

public class RequestEndpointTests(ITestOutputHelper testOutputHelper)
{
	private readonly ITestOutputHelper _testOutputHelper = testOutputHelper;

	private readonly OpenDotaApi _openDotaApi = new();

	// Unable to test these endpoints:
	// GetParseRequestStateAsync - Cannot get valid request for testing because every request is immediately deleted.
	// SubmitNewParseRequestAsync - This endpoint requires changing data so testing it is not safe.
}