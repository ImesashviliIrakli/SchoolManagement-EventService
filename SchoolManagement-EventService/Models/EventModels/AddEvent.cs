using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_EventService.Models.EventModels
{
    public class AddEvent
    {
        [Required]
        [MaxLength(100)]
        public string EventTitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string EventDescription { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
