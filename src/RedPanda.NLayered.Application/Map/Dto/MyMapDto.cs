using EnsureThat;

namespace RedPanda.NLayered.Application.Map;

public class MyMapDto(string currentForecast)
{
    public string CurrentForecast { get; } = Ensure.Any.IsNotNull(currentForecast, nameof(currentForecast));
}
