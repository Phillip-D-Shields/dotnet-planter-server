using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planter.Data;
using Planter.Models;
using Planter.Services;

namespace Planter.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PlantingCalendarController : ControllerBase
  {
    private readonly PlantingCalendarService _service;

    public PlantingCalendarController(PlanterDbContext context)
    {
      _service = new PlantingCalendarService(context);
    }

    [HttpGet("{userId}")]
    public IActionResult GetUserCalendars(Guid userId)
    {
      var calendars = _service.GetUserCalendars(userId);
      return Ok(calendars);
    }

    [HttpPost]
    public IActionResult CreateCalendar(PlantingCalendar calendar)
    {
      var createdCalendar = _service.CreateCalendar(calendar);
      return CreatedAtAction(nameof(GetUserCalendars), new { userId = createdCalendar.UserId }, createdCalendar);
    }

    // Implement other actions to interact with planting calendars here ...
    [HttpPut("{id}")]
    public IActionResult UpdateCalendar(Guid id, PlantingCalendar updatedCalendar)
    {
      if (id != updatedCalendar.Id)
      {
        return BadRequest();
      }

      try
      {
        _service.UpdateCalendar(updatedCalendar);
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!_service.CalendarExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCalendar(Guid id)
    {
      _service.DeleteCalendar(id);
      return NoContent();
    }

  }
}
