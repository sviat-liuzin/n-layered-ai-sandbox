using EnsureThat;
using Microsoft.AspNetCore.Mvc;
using RedPanda.NLayered.Application.Map;

namespace RedPanda.NLayered.Web.Controllers;

[ApiController]
[Route("my")]
public class MyController(IMapService mapService) : ControllerBase
{
    private readonly IMapService _mapService = Ensure.Any.IsNotNull(mapService, nameof(mapService));

    [HttpGet]
    [Route("map")]
    public async Task<IActionResult> GetMyMap(CancellationToken cancellationToken)
    {
        var result = await _mapService.UpdateMyMapForTodayAsync(cancellationToken);

        return Ok(result);
    }
}