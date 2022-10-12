using Microsoft.EntityFrameworkCore;
using SchoolManagement_EventService.Data;
using SchoolManagement_EventService.Models.EventModels;

namespace SchoolManagement_EventService.Repositories.EventRepo
{
    public class EventRepository : IEventRepository
    {
        #region Injection
        private readonly AppDbContext _context;
        public EventRepository(AppDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Get events | Get specific Event
        public async Task<List<Event>> GetEvents()
        {
            var events = await _context.Events.ToListAsync();
            return events;
        }

        public async Task<Event> GetEventById(int id)
        {
            var selectedEvent = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
            return selectedEvent;
        }
        #endregion

        #region Add new event
        public async Task<bool> Add(Event newEvent)
        {
            if(newEvent == null)
            {
                return false;
            }

            try
            {
                await _context.Events.AddAsync(newEvent);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        #endregion
    }
}
