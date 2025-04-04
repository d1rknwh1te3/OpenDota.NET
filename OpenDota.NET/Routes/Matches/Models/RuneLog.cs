namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a rune log
/// </summary>
public class RuneLog
{
	/// <summary>
	/// Gets a key of the picked up rune
	/// </summary>
	[JsonPropertyName("key")]
	public long Key { get; init; }

	/// <summary>
	/// Gets a time in seconds when the rune was picked up
	/// </summary>
	[JsonPropertyName("time")]
	public long Time { get; init; }
}