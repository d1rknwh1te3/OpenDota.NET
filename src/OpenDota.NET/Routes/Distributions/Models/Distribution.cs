namespace OpenDotaDotNet.Routes.Distributions.Models;

public class Distribution
{
	/// <summary>
	/// Gets or sets the ranks.
	/// </summary>
	[JsonProperty("ranks")]
	public Ranks Ranks { get; set; }
}