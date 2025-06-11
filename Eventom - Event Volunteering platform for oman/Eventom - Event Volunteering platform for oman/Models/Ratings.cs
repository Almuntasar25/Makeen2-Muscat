using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom___Event_Volunteering_platform_for_oman.Models
{
    public class Ratings
    {
        public int id { get; set; }
        [ForeignKey("EventId")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [ForeignKey("VolunteersId")]
        public int VolunteersId { get; set; }
        public Volunteers volunteers { get; set; }

        [ForeignKey("CreatorId")]
        public int CreatorId { get; set; }
        public Users Creator { get; set; }

        public int PunctualityRating { get; set; }
        public int QualityRating { get; set; }
        public int TeamworkRating { get; set; }
        public int InitiveRating { get; set; }









    }
}
