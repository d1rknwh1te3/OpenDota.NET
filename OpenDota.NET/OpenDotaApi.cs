namespace OpenDotaDotNet;

// TODO: Implement PLAYERS BY RANK endpoint

/// <inheritdoc />
public class OpenDotaApi : IOpenDotaApi
{
	/// <summary>
	/// Creates new instance of <see cref="OpenDotaApi"/>
	/// </summary>
	/// <param name="configure">The configure.</param>
	public OpenDotaApi(Action<OpenDotaSettings>? configure = null)
	{
		var settings = new OpenDotaSettings();

		configure?.Invoke(settings);

		var request = new Requester(settings);
		
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
	public IBenchmarkEndpoint Benchmarks { get; }

	/// <inheritdoc />
	public IConstantsEndpoint Constants { get; }

	/// <inheritdoc />
	public IDistributionsEndpoint Distributions { get; }

	/// <inheritdoc />
	public IExplorerEndpoint Explorer { get; }

	/// <inheritdoc />
	public IFindMatchesEndpoint FindMatches { get; }

	/// <inheritdoc />
	public IHealthEndpoint Health { get; }

	/// <inheritdoc />
	public IHeroesEndpoint Heroes { get; }

	/// <inheritdoc />
	public IHeroStatsEndpoint HeroStats { get; }

	/// <inheritdoc />
	public ILeagueEndpoint League { get; }

	/// <inheritdoc />
	public ILiveEndpoint Live { get; }

	/// <inheritdoc />
	public IMatchesEndpoint Matches { get; }

	/// <inheritdoc />
	public IMetadataEndpoint Metadata { get; }

	/// <inheritdoc />
	public IParsedMatchesEndpoint ParsedMatches { get; }

	/// <inheritdoc />
	public IPlayersEndpoint Players { get; }

	/// <inheritdoc />
	public IProMatchEndpoint ProMatches { get; }

	/// <inheritdoc />
	public IProPlayersEndpoint ProPlayers { get; }
	/// <inheritdoc />
	public IPublicMatchesEndpoint PublicMatches { get; }
	/// <inheritdoc />
	public IRankingsEndpoint Rankings { get; }

	/// <inheritdoc />
	public IRecordsEndpoint Records { get; }

	/// <inheritdoc />
	public IRequestEndpoint Request { get; }

	/// <inheritdoc />
	public IScenariosEndpoint Scenarios { get; }

	/// <inheritdoc />
	public ISchemaEndpoint Schema { get; }

	/// <inheritdoc />
	public ISearchEndpoint Search { get; }
	
	/// <inheritdoc />
	public ITeamsEndpoint Teams { get; }
}