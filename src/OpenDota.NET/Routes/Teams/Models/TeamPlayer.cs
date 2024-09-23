namespace OpenDotaDotNet.Routes.Teams.Models;

/// <summary>
/// Represents a team player.
/// </summary>
public class TeamPlayer
{
	/// <summary>
	/// Gets or sets account ID of the player.
	/// </summary>
	[JsonProperty("account_id")]
	public required long AccountId { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("games_played")]
	public long GamesPlayed { get; set; }

	[JsonProperty("wins")]
	public long Wins { get; set; }

	[JsonProperty("is_current_team_member")]
	public bool? IsCurrentTeamMember { get; set; }
}