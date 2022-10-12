using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement_EventService.Models.EventModels;
using SchoolManagement_EventService.Repositories.EventRepo;

namespace SchoolManagement_EventService.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        #region Injection
        private readonly IEventRepository _events;
        private readonly IMapper _mapper;
        public EventController(IEventRepository events, IMapper mapper)
        {
            _events = events;
            _mapper = mapper;
        }
        #endregion

        #region Get events | Get event by id
        [HttpGet("get-all-events")]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _events.GetEvents();

            if (events == null)
            {
                return BadRequest();
            }

            return Ok(events);
        }

        [HttpGet("get-event-by-id/{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            var selectedEvent = await _events.GetEventById(id);

            if (selectedEvent == null)
            {
                return BadRequest();
            }

            return Ok(selectedEvent);
        }
        #endregion

        #region Add new event
        [HttpPost("add-new-event")]
        public async Task<IActionResult> Post([FromBody] AddEvent body)
        {
            var newEvent = _mapper.Map<Event>(body);
            var add = await _events.Add(newEvent);

            if (!add)
            {
                return BadRequest();
            }

            return Ok(add);
        }
        #endregion
    }
}
