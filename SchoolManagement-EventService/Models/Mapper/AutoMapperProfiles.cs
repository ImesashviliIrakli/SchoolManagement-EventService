using AutoMapper;
using SchoolManagement_EventService.Models.EventModels;

namespace SchoolManagement_EventService.Models.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AddEvent, Event>();
        }
    }
}
