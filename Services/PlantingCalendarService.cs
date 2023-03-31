using System;
using System.Collections.Generic;
using System.Linq;
using Planter.Data;
using Planter.Models;

namespace Planter.Services
{
  public class PlantingCalendarService
  {
    private readonly PlanterDbContext _context;

    public PlantingCalendarService(PlanterDbContext context)
    {
      _context = context;
    }

    public List<PlantingCalendar> GetUserCalendars(Guid userId)
    {
      return _context.PlantingCalendars.Where(c => c.UserId == userId).ToList();
    }

    public PlantingCalendar CreateCalendar(PlantingCalendar calendar)
    {

      _context.PlantingCalendars.Add(calendar);
      _context.SaveChanges();

      return calendar;
    }

    public PlantingCalendar UpdateCalendar(PlantingCalendar calendar)
    {
      _context.PlantingCalendars.Update(calendar);
      _context.SaveChanges();

      return calendar;
    }

    public void DeleteCalendar(Guid id)
    {
      var calendar = _context.PlantingCalendars.Find(id);
      if (calendar != null)
      {
        _context.PlantingCalendars.Remove(calendar);
        _context.SaveChanges();
      }
    }

    internal bool CalendarExists(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}