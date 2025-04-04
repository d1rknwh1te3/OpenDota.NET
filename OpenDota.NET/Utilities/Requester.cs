namespace OpenDotaDotNet.Utilities;

public sealed class Requester : IDisposable
{
	private readonly HttpClient _httpClient;
	private readonly HttpClientHandler _httpClientHandler;
	

	private const string OpenDotaApi = "https://api.opendota.com/api/";

	/// <summary>
	/// Initializes a new instance of the <see cref="Requester"/> class.
	/// </summary>
	public Requester(OpenDotaSettings? settings = null)
	{
		settings ??= new OpenDotaSettings();

		ApiKey = settings.ApiKey;
		Options = settings.JsonSerializerOptions;

		_httpClientHandler = new HttpClientHandler { UseProxy = true, Proxy = settings.Proxy, };
		_httpClient = new HttpClient(_httpClientHandler) { Timeout = TimeSpan.FromSeconds(60), BaseAddress = new Uri(OpenDotaApi), };
	}

	private string? ApiKey { get; }
	private JsonSerializerOptions? Options { get; }

	internal async Task<T?> GetResponseAsync<T>(string url, List<string>? queryParameters = null)
		where T : class
	{
		var response = await GetRequestResponseMessageAsync(url, queryParameters?.ToList());
		response.EnsureSuccessStatusCode();

		var textResponse = await response.Content.ReadAsStringAsync();

		if (string.IsNullOrEmpty(textResponse))
			return null;

		var data = JsonSerializer.Deserialize<T>(textResponse, Options);
		return data;
	}

	internal Task<HttpResponseMessage> PostRequestAsync(string url, HttpContent? content = null) => _httpClient.PostAsync(url, content);

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