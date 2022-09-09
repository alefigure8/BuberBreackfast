using Microsoft.AspNetCore.Mvc;
using BuberBreackfast.Contracts.Breakfast;
namespace BubberBreackfast.Controllers;

[ApiController]
public class BreakfastController : ControllerBase
{
    [HttpPost("/breakfast")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }
}