using System.Text.Json.Serialization;

namespace OpenDotaDotNet.Routes.Heroes.Models;

public class HeroItemPopularity
{
	[JsonProperty("start_game_items")]
	public Dictionary<string, int> StartGameItems { get; set; }

	[JsonProperty("early_game_items")]
	public Dictionary<string, int> EarlyGameItems { get; set; }

	[JsonProperty("mid_game_items")]
	public Dictionary<string, int> MidGameItems { get; set; }

	[JsonProperty("late_game_items")]
	public Dictionary<string, int> LateGameItems { get; set; }
}