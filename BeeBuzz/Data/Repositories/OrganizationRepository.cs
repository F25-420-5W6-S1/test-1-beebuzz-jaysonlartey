using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data.Repositories
{
    public class OrganizationRepository: BeeBuzzGenericGenericRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(ApplicationDbContext context, ILogger<BeeBuzzGenericGenericRepository<Organization>> logger) : base(context, logger) { }
        public IEnumerable<ApplicationUser> GetAllUsers(int orgId)
        {

            return _context.Users
                .Where(u => u.OrganizationId == orgId)
                .ToList();
        }

        public IEnumerable<Beehive> GetAllBeehives(int orgId)
        {
            return _context.Beehives
                .Where(b => b.OrganizationId == orgId)
                .ToList();
        }
    }
}