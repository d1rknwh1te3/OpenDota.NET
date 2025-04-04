namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a parse request state.
/// </summary>
public class ParseRequestState
{
	/// <summary>
	/// Gets the id of the parse request.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; init; }

	/// <summary>
	/// Gets the type of the parse request.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; init; }

	/// <summary>
	/// Gets the timestamp of the parse request.
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = DateTimeOffset.MinValue;

	/// <summary>
	/// Gets the attempts of the parse request.
	/// </summary>
	[JsonPropertyName("attempts")]
	public int Attempts { get; init; }
	
	/// <summary>
	/// Gets the data of the parse request.
	/// </summary>
	[JsonPropertyName("data")]
	public Data Data { get; init; } = new();

	/// <summary>
	/// Gets the next attempt time of the parse request.
	/// </summary>
	[JsonPropertyName("next_attempt_time")]
	public DateTimeOffset NextAttemptTime { get; init; } = DateTimeOffset.MinValue;

	/// <summary>
	/// Gets the priority of the parse request.
	/// </summary>
	[JsonPropertyName("priority")]
	public int Priority { get; init; }

	/// <summary>
	/// Gets the job id of the parse request.
	/// </summary>
	[JsonPropertyName("jobId")]
	public long JobId { get; init; }
}