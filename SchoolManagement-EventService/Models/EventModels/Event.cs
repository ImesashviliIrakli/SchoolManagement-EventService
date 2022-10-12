using System.ComponentModel.DataAnnotations;

namespace SchoolManagement_EventService.Models.EventModels
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EventTitle { get; set; }

        [Required]
        public string EventDescription { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
