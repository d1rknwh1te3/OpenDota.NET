namespace OpenDotaDotNet.Models.Metadata;

public class Scenarios
{
	[JsonProperty("itemCost")]
	public int ItemCost { get; set; }

	[JsonProperty("timings")]
	public int[] Timings { get; set; }

	[JsonProperty("gameDurationBucket")]
	public int[] GameDurationBucket { get; set; }

	[JsonProperty("teamScenariosQueryParams")]
	public string[] TeamScenariosQueryParams { get; set; }
}