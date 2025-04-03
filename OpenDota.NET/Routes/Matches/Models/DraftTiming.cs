namespace OpenDotaDotNet.Routes.Matches.Models;

public class DraftTiming
{
	// The order of pick
	[JsonPropertyName("order")]
	public int Order { get; set; }

	// Whether a hero was picked or not. True if hero was picked, false if hero was banned
	[JsonPropertyName("pick")]
	public bool Pick { get; set; }

	// The id of the active team doing the picking
	[JsonPropertyName("active_team")]
	public int ActiveTeam { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; set; }

	/// <summary>
	/// Gets or sets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public long? PlayerSlot { get; set; }

	// Extra time left
	[JsonPropertyName("extra_time")]
	public int ExtraTime { get; set; }

	// Total time taken to pick ther hero
	[JsonPropertyName("total_time_taken")]
	public int TotalTimeTaken { get; set; }
}