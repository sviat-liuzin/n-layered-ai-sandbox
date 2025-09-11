namespace RedPanda.NLayered.Domain.Services.Map;

internal class MapService : IMapService
{
    public Task<MyMap> GetMyMapAsync(CancellationToken cancellationToken = default)
    {
        var myMap = new MyMap("blank_forecast");

        return Task.FromResult(myMap);
    }
}