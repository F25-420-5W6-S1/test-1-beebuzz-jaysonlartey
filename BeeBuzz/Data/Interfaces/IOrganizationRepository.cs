using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Interfaces
{
    public interface IOrganizationRepository: IBeeBuzzGenericRepository<Organization>
    {
        IEnumerable<ApplicationUser> GetAllUsers(int orgId);
        IEnumerable<Beehive> GetAllBeehives(int orgId);
    }
}
