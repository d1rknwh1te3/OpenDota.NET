namespace OpenDotaDotNet.Routes.Heroes.Models;

public class HeroItemPopularity
{
	[JsonPropertyName("start_game_items")]
	public Dictionary<string, int> StartGameItems { get; set; }

	[JsonPropertyName("early_game_items")]
	public Dictionary<string, int> EarlyGameItems { get; set; }

	[JsonPropertyName("mid_game_items")]
	public Dictionary<string, int> MidGameItems { get; set; }

	[JsonPropertyName("late_game_items")]
	public Dictionary<string, int> LateGameItems { get; set; }
}