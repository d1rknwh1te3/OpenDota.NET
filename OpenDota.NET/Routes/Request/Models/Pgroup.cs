namespace OpenDotaDotNet.Routes.Request.Models;

/// <summary>
/// Represents a player group.
/// </summary>
public class Pgroup
{
	/// <summary>
	/// Gets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; init; }

	/// <summary>
	/// Gets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int HeroId { get; init; }

	/// <summary>
	/// Gets which slot the player is in. 0-127 are Radiant, 128-255 are Dire.
	/// </summary>
	[JsonPropertyName("player_slot")]
	public int PlayerSlot { get; init; }
}