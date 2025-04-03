namespace OpenDotaDotNet.Routes.Teams.Models;

/// <summary>
/// Represents a team player.
/// </summary>
public class TeamPlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonPropertyName("account_id")]
	public required long AccountId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("games_played")]
	public long GamesPlayed { get; set; }

	[JsonPropertyName("wins")]
	public long Wins { get; set; }

	[JsonPropertyName("is_current_team_member")]
	public bool? IsCurrentTeamMember { get; set; }
}