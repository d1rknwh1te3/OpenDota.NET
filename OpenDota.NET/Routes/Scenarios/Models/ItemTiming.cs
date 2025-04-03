namespace OpenDotaDotNet.Routes.Scenarios.Models;

/// <summary>
/// Represents the timing of an item.
/// </summary>
public class ItemTiming
{
	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; set; }

	[JsonPropertyName("item")]
	public string Item { get; set; }

	[JsonPropertyName("time")]
	public int Time { get; set; }

	[JsonPropertyName("games")]
	public int Games { get; set; }

	[JsonPropertyName("wins")]
	public int Wins { get; set; }
}