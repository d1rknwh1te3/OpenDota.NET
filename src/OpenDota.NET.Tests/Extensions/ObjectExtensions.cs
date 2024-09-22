using System.IO;

namespace OpenDota.NET.Tests.Extensions;

public static class ObjectExtensions
{
	public static string ToJsonString(this object obj) => JsonConvert.SerializeObject(obj);
}