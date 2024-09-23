namespace OpenDotaDotNet.Routes.Matches.Models;

public class PickBan
{
	// Whether it was picked or banned. False means the hero was banned, true means the hero was picked.
	[JsonProperty("is_pick")]
	public bool IsPick { get; set; }

	// Id of the hero picked or banned
	[JsonProperty("hero_id")]
	public int HeroId { get; set; }

	// Team that picked or banned the hero
	[JsonProperty("team")]
	public int Team { get; set; }

	// Order of pick or ban
	[JsonProperty("order")]
	public int Order { get; set; }

	// Order of pick or ban (from what ive seen its the same value as above always)
	[JsonProperty("ord")]
	public long Ord { get; set; }

	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonProperty("match_id")]
	public long MatchId { get; set; }
}