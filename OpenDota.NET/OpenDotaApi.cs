﻿namespace OpenDotaDotNet;

// TODO: Implement PLAYERS BY RANK endpoint

/// <inheritdoc />
public class OpenDotaApi : IOpenDotaApi
{
	/// <summary>
	/// Creates new instance of <see cref="OpenDotaApi"/>
	/// </summary>
	/// <param name="apiKey">OpenDota API Key.</param>
	/// <param name="proxy">Proxy (if needed).</param>
	public OpenDotaApi(string? apiKey = null, IWebProxy? proxy = null)
	{
		var request = new Requester(apiKey, proxy);
		
		Matches = new MatchesEndpoint(request);
		Players = new PlayersEndpoint(request);
		ProPlayers = new ProPlayersEndpoint(request);
		ProMatches = new ProMatchesEndpoint(request);
		PublicMatches = new PublicMatchesEndpoint(request);
		ParsedMatches = new ParsedMatchesEndpoint(request);
		Explorer = new ExplorerEndpoint(request);
		Metadata = new MetadataEndpoint(request);
		Distributions = new DistributionsEndpoint(request);
		Search = new SearchEndpoint(request);
		Rankings = new RankingsEndpoint(request);
		Benchmarks = new BenchmarksEndpoint(request);
		Status = new StatusEndpoint(request);
		Health = new HealthEndpoint(request);
		Request = new RequestEndpoint(request);
		FindMatches = new FindMatchesEndpoint(request);
		Heroes = new HeroesEndpoint(request);
		HeroStats = new HeroStatsEndpoint(request);
		League = new LeagueEndpoint(request);
		Teams = new TeamsEndpoint(request);
		Records = new RecordsEndpoint(request);
		Live = new LiveEndpoint(request);
		Scenarios = new ScenariosEndpoint(request);
		Schema = new SchemaEndpoint(request);
		Constants = new ConstantsEndpoint(request);
	}

	/// <inheritdoc />
	public IMatchesEndpoint Matches { get; }

	/// <inheritdoc />
	public IPlayersEndpoint Players { get; }

	/// <inheritdoc />
	public IProPlayersEndpoint ProPlayers { get; }

	/// <inheritdoc />
	public IProMatchEndpoint ProMatches { get; }

	/// <inheritdoc />
	public IPublicMatchesEndpoint PublicMatches { get; }

	/// <inheritdoc />
	public IParsedMatchesEndpoint ParsedMatches { get; }

	/// <inheritdoc />
	public IExplorerEndpoint Explorer { get; }

	/// <inheritdoc />
	public IMetadataEndpoint Metadata { get; }

	/// <inheritdoc />
	public IDistributionsEndpoint Distributions { get; }

	/// <inheritdoc />
	public ISearchEndpoint Search { get; }

	/// <inheritdoc />
	public IRankingsEndpoint Rankings { get; }

	/// <inheritdoc />
	public IBenchmarkEndpoint Benchmarks { get; }

	/// <inheritdoc />
	public IStatusEndpoint Status { get; }

	/// <inheritdoc />
	public IHealthEndpoint Health { get; }

	/// <inheritdoc />
	public IRequestEndpoint Request { get; }

	/// <inheritdoc />
	public IFindMatchesEndpoint FindMatches { get; }

	/// <inheritdoc />
	public IHeroesEndpoint Heroes { get; }

	/// <inheritdoc />
	public IHeroStatsEndpoint HeroStats { get; }

	/// <inheritdoc />
	public ILeagueEndpoint League { get; }

	/// <inheritdoc />
	public ITeamsEndpoint Teams { get; }

	/// <inheritdoc />
	public IRecordsEndpoint Records { get; }

	/// <inheritdoc />
	public ILiveEndpoint Live { get; }

	/// <inheritdoc />
	public IScenariosEndpoint Scenarios { get; }

	/// <inheritdoc />
	public ISchemaEndpoint Schema { get; }

	/// <inheritdoc />
	public IConstantsEndpoint Constants { get; }
}