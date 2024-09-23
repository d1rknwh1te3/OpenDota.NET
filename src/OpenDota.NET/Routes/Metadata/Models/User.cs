namespace OpenDotaDotNet.Routes.Metadata.Models;

/// <summary>
/// Represents the user.
/// </summary>
public class User
{
	/// <summary>
	/// Gets or sets the account identifier.
	/// </summary>
	[JsonProperty("account_id")]
	public int AccountId { get; set; }
}