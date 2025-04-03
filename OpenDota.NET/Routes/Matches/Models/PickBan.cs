namespace OpenDotaDotNet.Routes.Matches.Models;

public class PickBan
{
	// Whether it was picked or banned. False means the hero was banned, true means the hero was picked.
	[JsonPropertyName("is_pick")]
	public bool IsPick { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero picked or banned.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; set; }

	// Team that picked or banned the hero
	[JsonPropertyName("team")]
	public int Team { get; set; }

	// Order of pick or ban
	[JsonPropertyName("order")]
	public int Order { get; set; }

	// Order of pick or ban (from what ive seen its the same value as above always)
	[JsonPropertyName("ord")]
	public long Ord { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }
}