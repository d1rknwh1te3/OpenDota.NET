﻿namespace OpenDotaDotNet.Interfaces;

/// <summary>
/// The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.
/// 
/// </summary>
/// <remarks>
/// Full documentation is available on <see href="https://docs.opendota.com/">OpenDota</see>.
/// You can find data that can be used to convert hero and ability IDs and other information provided by
/// the API from the <see href="https://github.com/odota/dotaconstants">Dota Constants</see> repository.
/// </remarks>
public interface IOpenDotaApi
{
	/// <inheritdoc cref="IMatchesEndpoint" />
	IMatchesEndpoint Matches {  get; }

	/// <inheritdoc cref="IPlayersEndpoint" />
	IPlayersEndpoint Players { get; }

	/// <inheritdoc cref="IProPlayerEndpoint" />
	IProPlayerEndpoint ProPlayers { get; }

	/// <inheritdoc cref="IProMatchEndpoint" />
	IProMatchEndpoint ProMatches { get; }

	/// <inheritdoc cref="IPublicMatchesEndpoint" />
	IPublicMatchesEndpoint PublicMatches { get; }

	/// <inheritdoc cref="IParsedMatchesEndpoint" />
	IParsedMatchesEndpoint ParsedMatches { get; }

	/// <inheritdoc cref="IExplorerEndpoint" />
	IExplorerEndpoint Explorer { get; }

	/// <inheritdoc cref="IMetadataEndpoint" />
	IMetadataEndpoint Metadata { get; }

	/// <inheritdoc cref="IDistributionsEndpoint" />
	IDistributionsEndpoint Distributions { get; }

	/// <inheritdoc cref="ISearchEndpoint" />
	ISearchEndpoint Search { get; }

	/// <inheritdoc cref="IRankingsEndpoint" />
	IRankingsEndpoint Rankings { get; }

	/// <inheritdoc cref="IBenchmarkEndpoint" />
	IBenchmarkEndpoint Benchmarks { get; }

	/// <inheritdoc cref="IStatusEndpoint" />
	IStatusEndpoint Status { get; }
	
	/// <inheritdoc cref="IHealthEndpoint" />
	IHealthEndpoint Health { get; }

	/// <inheritdoc cref="IRequestEndpoint" />
	IRequestEndpoint Request { get; }

	/// <inheritdoc cref="IFindMatchesEndpoint" />
	IFindMatchesEndpoint FindMatches { get; }

	/// <inheritdoc cref="IHeroesEndpoint" />
	IHeroesEndpoint Heroes { get; }

	/// <inheritdoc cref="IHeroStatsEndpoint" />
	IHeroStatsEndpoint HeroStats { get; }

	/// <inheritdoc cref="ILeagueEndpoint" />
	ILeagueEndpoint League { get; }

	/// <inheritdoc cref="ITeamsEndpoint" />
	ITeamsEndpoint Teams { get; }

	/// <inheritdoc cref="IRecordsEndpoint" />
	IRecordsEndpoint Records { get; }

	/// <inheritdoc cref="ILiveEndpoint" />
	ILiveEndpoint Live { get; }

	/// <inheritdoc cref="IScenariosEndpoint" />
	IScenariosEndpoint Scenarios { get; }

	/// <inheritdoc cref="ISchemaEndpoint" />
	ISchemaEndpoint Schema { get; }

	/// <inheritdoc cref="IConstantsEndpoint" />
	IConstantsEndpoint Constants { get; }
}