using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom___Event_Volunteering_platform_for_oman.Models
{
    public class Committees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequiredVolunteers { get; set; }
        public string RequiredSkills { get; set; }

        [ForeignKey("LeaderId")]
        public int LeaderId { get; set; }
        public Volunteers volunteers { get; set; }

        [ForeignKey("EventId")]
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
