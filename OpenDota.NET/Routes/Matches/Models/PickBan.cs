namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a pick or ban
/// </summary>
public class PickBan
{
	/// <summary>
	/// Gets whether it was picked or banned. False means the hero was banned, true means the hero was picked.
	/// </summary>
	[JsonPropertyName("is_pick")]
	public bool? IsPick { get; init; }

	/// <summary>
	/// Gets the ID value of the hero picked or banned.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; init; }

	/// <summary>
	/// Gets team that picked or banned the hero
	/// </summary>
	[JsonPropertyName("team")]
	public int Team { get; init; }

	/// <summary>
	/// Gets order of pick or ban
	/// </summary>
	[JsonPropertyName("order")]
	public int Order { get; init; }

	/// <summary>
	/// Gets order of pick or ban (from what ive seen its the same value as above always)
	/// </summary>
	[JsonPropertyName("ord")]
	public long? Ord { get; init; }

	/// <summary>
	/// Gets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; init; }
}