namespace OpenDotaDotNet.Models.Search;

public class SearchPlayerResponse
{
	[JsonProperty("account_id")]
	public long AccountId { get; set; }

	[JsonProperty("personaname")]
	public string PersonaName { get; set; }

	[JsonProperty("avatarfull")]
	public Uri AvatarFull { get; set; }

	/// <summary>
	/// Gets or sets last_match_time. May not be present or null.
	/// </summary>
	[JsonProperty("last_match_time")]
	public DateTimeOffset? LastMatchTime { get; set; }

	[JsonProperty("similarity")]
	public double Similarity { get; set; }
}