using EnsureThat;

namespace RedPanda.NLayered.Domain;

public class MyMap(string currentForecast)
{
    public string CurrentForecast { get; }  = Ensure.Any.IsNotNull(currentForecast, nameof(currentForecast));
}