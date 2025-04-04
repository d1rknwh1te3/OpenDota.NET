namespace OpenDotaDotNet.Routes.Matches.Models;

/// <summary>
/// Represents a permanent buff.
/// </summary>
public class PermanentBuff
{
	/// <summary>
	/// Gets the list of constants can be found here: https://github.com/odota/dotaconstants/blob/master/json/permanent_buffs.json
	/// </summary>
	[JsonPropertyName("permanent_buff")]
	public long PermanentBuffPermanentBuff { get; init; }

	/// <summary>
	/// Gets a stack count
	/// </summary>
	[JsonPropertyName("stack_count")]
	public long StackCount { get; init; }
}