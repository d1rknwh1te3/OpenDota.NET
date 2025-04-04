namespace OpenDotaDotNet.Routes.Scenarios.Enums;

/// <summary>
/// Represents a scenario
/// </summary>
public enum Scenario
{
	/// <summary>
	/// No scenario only for internal usage
	/// </summary>
	[JsonIgnore] None = 0,

	/// <summary>
	/// Courier kill
	/// </summary>
	[JsonPropertyName("courier_kill")] CourierKill = 1,

	/// <summary>
	/// First blood
	/// </summary>
	[JsonPropertyName("first_blood")] FirstBlood = 2,

	/// <summary>
	/// Neg chat 1 min
	/// </summary>
	[JsonPropertyName("neg_chat_1min")] NegChat1Min = 3,

	/// <summary>
	/// Pos chat 1 min
	/// </summary>
	[JsonPropertyName("pos_chat_1min")] PosChat1Min = 4
}