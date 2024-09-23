namespace OpenDotaDotNet.Extensions;

public static class EnumExtensions
{
	public static string ToSnakeCase(this Enum enumerable)
	{
		var str = enumerable.ToString();

		return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString())).ToLower();
	}
}