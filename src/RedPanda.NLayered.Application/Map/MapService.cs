using AutoMapper;
using EnsureThat;
using RedPanda.NLayered.Application.Map.Dto;
using RedPanda.NLayered.Integration.Forecast.WeatherApi;
using DomainMapService = RedPanda.NLayered.Domain.Services.Map.IMapService;

namespace RedPanda.NLayered.Application.Map;

internal class MapService(
    DomainMapService domainMapService,
    IWeatherApiClient weatherApiClient,
    IMapper mapper) : IMapService
{
    public readonly DomainMapService _domainMapService = Ensure.Any.IsNotNull(domainMapService, nameof(domainMapService));

    public readonly IWeatherApiClient _weatherApiClient = Ensure.Any.IsNotNull(weatherApiClient, nameof(weatherApiClient));

    public readonly IMapper _mapper = Ensure.Any.IsNotNull(mapper, nameof(mapper));

    public async Task<MyMapDto> UpdateMyMapForTodayAsync(CancellationToken cancellationToken = default)
    {
        var weather = await _weatherApiClient.GetCurrentWeatherAsync("Vilnius", cancellationToken);

        var domainMap = await _domainMapService.UpdateMyMapForTodayAsync(weather.CurrentWeather.TempC, cancellationToken);

        var mapDto = _mapper.Map<MyMapDto>(domainMap);

        return mapDto;
    }
}