namespace OpenDotaDotNet.Routes.Search.Models;

/// <summary>
/// Represents a response by PersonaName.
/// </summary>
public class PlayerResponse
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	[JsonPropertyName("personaname")]
	public string PersonaName { get; set; }

	[JsonPropertyName("avatarfull")]
	public Uri AvatarFull { get; set; }

	/// <summary>
	/// Gets or sets last_match_time. May not be present or null.
	/// </summary>
	[JsonPropertyName("last_match_time")]
	public DateTimeOffset? LastMatchTime { get; set; }

	[JsonPropertyName("similarity")]
	public double Similarity { get; set; }
}