﻿using League = OpenDotaDotNet.Models.Leagues.League;

namespace OpenDotaDotNet.Interfaces.Endpoints;

/// <summary>
/// League endpoint.
/// </summary>
public interface ILeagueEndpoint
{
	/// <summary>
	/// Get league data.
	/// </summary>
	/// <returns>League data.</returns>
	Task<IEnumerable<League>?> GetLeaguesAsync();
}