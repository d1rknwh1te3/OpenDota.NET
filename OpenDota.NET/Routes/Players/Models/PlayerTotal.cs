namespace OpenDotaDotNet.Routes.Players.Models;

/// <summary>
/// Represents player total.
/// </summary>
public class PlayerTotal
{
	/// <summary>
	/// Gets or sets the field.
	/// </summary>
	[JsonPropertyName("field")]
	public string Field { get; init; } = string.Empty;

	/// <summary>
	/// Gets or sets the number.
	/// </summary>
	[JsonPropertyName("n")]
	public long Number { get; init; }

	/// <summary>
	/// Gets or sets the sum.
	/// </summary>
	[JsonPropertyName("sum")]
	public double Sum { get; init; }
}