using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class ApplicationUserRepository : BeeBuzzGenericGenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext context, ILogger<BeeBuzzGenericGenericRepository<ApplicationUser>> logger) : base(context, logger) { }
    }
}
