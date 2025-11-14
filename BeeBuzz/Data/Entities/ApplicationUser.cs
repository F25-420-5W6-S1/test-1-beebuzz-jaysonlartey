using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeeBuzz.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public int UserId { get; set; }
        public ICollection<Beehive> Beehives { get; set; }
        
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
