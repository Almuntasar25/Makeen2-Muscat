using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Eventom___Event_Volunteering_platform_for_oman.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int StartDateTime { get; set; }
        public int EndDateTime { get; set; }
        public string Location { get; set; }
        public string city { get; set; }
        public int RegistrationDeadline { get; set; }
        public string Status { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }

        [ForeignKey("CreatorId")]
        public int CreatorId { get; set; }
        public Creator creator { get; set; }
    }
}
