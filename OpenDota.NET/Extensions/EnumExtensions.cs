namespace OpenDotaDotNet.Extensions;

/// <summary>
/// Extension methods for <see cref="Enum"/>
/// </summary>
public static class EnumExtensions
{
	/// <summary>
	/// Converts enum to string snakecase.
	/// </summary>
	/// <param name="enumerable">The enumerable.</param>
	/// <returns> The snake case string.</returns>
	public static string ToSnakeCase(this Enum enumerable)
	{
		var str = enumerable.ToString();

		return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString())).ToLower();
	}
}