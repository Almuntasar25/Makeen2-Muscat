using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Eventom___Event_Volunteering_platform_for_oman.Models
{
    public class Users
    {
        public int Id { get; set; }
        
        public int Email { get; set; }
        public int PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string City { get; set; }

        //(Admin / EventCreator / Volunteer)
        public string UserType { get; set; }
        public string IsActive { get; set; }
        public int CreatedDate { get; set; }
        public int LastLoginDate { get; set; }

        [ForeignKey("VolunteerId")]
        public int VolunteerId { get; set; }
        public Volunteers volunteers { get; set; }
    }
}
