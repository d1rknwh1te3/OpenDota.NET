﻿namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// Status endpoint.
/// </summary>
public interface IStatusEndpoint
{
	/// <summary>
	/// Get current service statistics.
	/// </summary>
	/// <returns>Current service statistics.</returns>
	Task<ServiceStatistics?> GetServiceStatisticsAsync();
}