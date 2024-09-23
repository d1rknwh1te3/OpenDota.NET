namespace OpenDotaDotNet.Routes.Request;

/// <inheritdoc />
public class RequestEndpoint(Requester requester) : IRequestEndpoint
{
	/// <inheritdoc />
	public Task<ParseRequestState?> GetParseRequestStateAsync(long jobId) =>
		requester.GetResponseAsync<ParseRequestState>($"request/{jobId}");

	/// <inheritdoc />
	public async Task<ParseRequest?> SubmitNewParseRequestAsync(long matchId)
	{
		var response = await requester.PostRequestAsync($"request/{matchId}");
		response.EnsureSuccessStatusCode();

		var serializer = new JsonSerializer();
		var stringReader = new StringReader(await response.Content.ReadAsStringAsync());
		var reader = new JsonTextReader(stringReader);

		// TODO: json to class

		var parseRequest = serializer.Deserialize<ParseRequest>(reader);

		return parseRequest;
	}
}