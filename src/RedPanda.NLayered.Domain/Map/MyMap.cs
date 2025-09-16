using EnsureThat;

namespace RedPanda.NLayered.Domain.Map;

public class MyMap(
    Guid id,
    string currentForecast)
{
    public Guid Id { get; } = Ensure.Any.IsNotDefault(id, nameof(id));
    
    public string CurrentForecast { get; }  = Ensure.Any.IsNotNull(currentForecast, nameof(currentForecast));
}