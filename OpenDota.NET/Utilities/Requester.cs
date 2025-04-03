namespace OpenDotaDotNet.Utilities;

/// <summary>
/// Represents an OpenDota API request.
/// </summary>
/// <seealso cref="IDisposable" />
public sealed class Requester : IDisposable
{
	private readonly HttpClient _httpClient;
	private readonly HttpClientHandler _httpClientHandler;

	private const string OpenDotaApi = "https://api.opendota.com/api/";

	/// <summary>
	/// Initializes a new instance of the <see cref="Requester"/> class.
	/// </summary>
	/// <param name="apiKey">OpenDota API Key.</param>
	/// <param name="proxy">Proxy (if needed).</param>
	public Requester(string? apiKey = null, IWebProxy? proxy = null)
	{
		ApiKey = apiKey;

		_httpClientHandler = new HttpClientHandler { UseProxy = true, Proxy = proxy, };
		_httpClient = new HttpClient(_httpClientHandler) { Timeout = TimeSpan.FromSeconds(60), BaseAddress = new Uri(OpenDotaApi), };
	}

	private string? ApiKey { get; }

	/// <summary>
	/// Gets the response asynchronous.
	/// </summary>
	/// <typeparam name="T">Response type.</typeparam>
	/// <param name="url">The URL.</param>
	/// <param name="queryParameters">The query parameters.</param>
	/// <returns>Response.</returns>
	public async Task<T?> GetResponseAsync<T>(string url, IEnumerable<string>? queryParameters = null)
		where T : class
	{
		var response = await GetRequestResponseMessageAsync(url, queryParameters?.ToList());
		response.EnsureSuccessStatusCode();

		var textResponse = await response.Content.ReadAsStringAsync();

		if (string.IsNullOrEmpty(textResponse))
			return null;

		var data = JsonSerializer.Deserialize<T>(textResponse);
		return data;
	}

	/// <summary>
	/// Posts the request asynchronous.
	/// </summary>
	/// <param name="url">The URL.</param>
	/// <param name="content">The content.</param>
	/// <returns>Response message.</returns>
	public Task<HttpResponseMessage> PostRequestAsync(string url, HttpContent? content = null)
	{
		return _httpClient.PostAsync(url, content);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	public void Dispose()
	{
		_httpClient.Dispose();
		_httpClientHandler.Dispose();
	}

	private Task<HttpResponseMessage> GetRequestResponseMessageAsync(string url, List<string>? queryParameters = null)
	{
		queryParameters ??= [];

		if (ApiKey != null)
			queryParameters.Add($"api_key={ApiKey}");

		var argumentsString = string.Join("&", queryParameters.Where(arg => !string.IsNullOrEmpty(arg)));
		var fullUrl = $"{url}?{argumentsString}";

		return _httpClient.GetAsync(fullUrl);
	}
}