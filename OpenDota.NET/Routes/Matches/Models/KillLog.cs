namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a kill log.
/// </summary>
public class KillLog
{
	/// <summary>
	/// Gets or sets the unit who got killed
	/// </summary>
	[JsonPropertyName("key")]
	public string? Key { get; set; }

	/// <summary>
	/// Gets or sets the time in seconds when the kill happened.
	/// </summary>
	[JsonPropertyName("time")]
	public long Time { get; set; }
}