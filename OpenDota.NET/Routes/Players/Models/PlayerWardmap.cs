namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player ward map.
/// </summary>
public class PlayerWardMap
{
	[JsonPropertyName("obs")]
	public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

	[JsonPropertyName("sen")]
	public Dictionary<string, Dictionary<string, long>> Sen { get; set; }
}