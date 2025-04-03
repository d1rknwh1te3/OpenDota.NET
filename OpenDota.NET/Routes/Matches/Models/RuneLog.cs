namespace OpenDotaDotNet.Routes.Matches.Models;

public class RuneLog
{
	// Key of the picked up rune
	[JsonPropertyName("key")]
	public long Key { get; set; }

	// Time in seconds when the rune was picked up
	[JsonPropertyName("time")]
	public long Time { get; set; }
}