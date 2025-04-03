namespace OpenDotaDotNet.Routes.Records.Models;

public class Record
{
	/// <summary>
	/// Gets or sets ID used to identify individual matches, e.g. 3703866531.
	/// </summary>
	[JsonPropertyName("match_id")]
	public long MatchId { get; set; }

	[JsonPropertyName("start_time")]
	public long StartTime { get; set; }

	/// <summary>
	/// Gets or sets the ID value of the hero played.
	/// </summary>
	[JsonPropertyName("hero_id")]
	public int? HeroId { get; set; }

	[JsonPropertyName("score")]
	public long Score { get; set; }
}