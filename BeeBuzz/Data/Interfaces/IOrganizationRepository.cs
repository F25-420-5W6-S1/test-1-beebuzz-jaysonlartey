using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Interfaces
{
    public interface IOrganizationRepository: IBeeBuzzGenericRepository<Organization>
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsers(int userId);
        Task<IEnumerable<Beehive>>GetAllBeehives(int beehiveId);
    }
}
