namespace OpenDotaDotNet.Routes.Scenarios.Models;

/// <summary>
/// Represents the timing of an item.
/// </summary>
public class ItemTiming
{
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	[JsonProperty("item")]
	public string Item { get; set; }

	[JsonProperty("time")]
	public int Time { get; set; }

	[JsonProperty("games")]
	public int Games { get; set; }

	[JsonProperty("wins")]
	public int Wins { get; set; }
}