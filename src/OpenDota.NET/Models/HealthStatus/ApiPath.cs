﻿namespace OpenDotaDotNet.Models.HealthStatus;

/// <summary>
/// Represents an API path.
/// </summary>
public class ApiPath
{
	/// <summary>
	/// Gets or sets the hostname.
	/// </summary>
	[JsonProperty("hostname")]
	public string Hostname { get; set; }

	/// <summary>
	/// Gets or sets the count.
	/// </summary>
	[JsonProperty("count")]
	public string Count { get; set; }
}