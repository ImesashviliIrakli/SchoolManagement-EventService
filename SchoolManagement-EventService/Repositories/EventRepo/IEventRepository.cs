using SchoolManagement_EventService.Models.EventModels;

namespace SchoolManagement_EventService.Repositories.EventRepo
{
    public interface IEventRepository
    {
        public Task<List<Event>> GetEvents();
        public Task<Event> GetEventById(int id);
        public Task<bool> Add(Event newEvent);
    }
}
