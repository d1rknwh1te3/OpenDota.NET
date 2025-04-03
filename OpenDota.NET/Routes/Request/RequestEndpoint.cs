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

		var content = await response.Content.ReadAsStringAsync();

		// TODO: json to class

		var parseRequest = JsonSerializer.Deserialize<ParseRequest>(content);

		return parseRequest;
	}
}