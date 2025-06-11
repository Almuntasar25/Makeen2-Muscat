using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom___Event_Volunteering_platform_for_oman.Models
{
    public class Applications
    {
        public int Id { get; set; }
        public int ApplicationDate { get; set; }
        public string Status { get; set; }
        public string MotivationStatement { get; set; }
        public string RelevantExperience { get; set; }
        public int DecisionDate { get; set; }
        public string DecisionReason { get; set; }

        [ForeignKey("VounteerId")]
        public int VounteerId { get; set; }
        public Volunteers volunteers { get; set; }

        [ForeignKey("CommitteeId")]

        public int CommitteeId { get; set; }
        public Committees committees { get; set; }

        
    }
}
