using Microsoft.AspNetCore.Mvc;
using BuberBreackfast.Contracts.Breakfast;
using BubberBreackfast.Models;
using BubberBreackfast.Services.Breakfast;
namespace BubberBreackfast.Controllers;

[ApiController]
[Route("breakfasts")]
public class BreakfastController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var Breakfast = new Breakfast(
            Guid.NewGuid(), 
            request.Name, 
            request.Description, 
            request.StartDateTime, 
            request.EndDateTime, 
            DateTime.UtcNow, 
            request.Savory, 
            request.Sweet);

        _breakfastService.CreateBreakfast(Breakfast);
        
        var response = new BreakfastResponse(
            Breakfast.Id, 
            Breakfast.Name, 
            Breakfast.Description, 
            Breakfast.StartDateTime, 
            Breakfast.EndDateTime, 
            Breakfast.LastModifiedDateTime, 
            Breakfast.Savory, 
            Breakfast.Sweet);

        return CreatedAtAction(
            actionName: nameof(GetBreakfast),
            routeValues: new { id = Breakfast.Id },
            value: response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        Breakfast breakfast = _breakfastService.GetBreakfast(id);

        var response = new BreakfastResponse(
            breakfast.Id, 
            breakfast.Name, 
            breakfast.Description, 
            breakfast.StartDateTime, 
            breakfast.EndDateTime, 
            breakfast.LastModifiedDateTime, 
            breakfast.Savory, 
            breakfast.Sweet);

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpserBreakfast(Guid id, UpserBreakfastRequest request)
    {
        return Ok(request);
    }

        [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }

}