using VillageAdminApp.API.Model;

namespace VillageAdminApp.API.Infrastructure.Repositories
{
    public interface IVillageRepository : IRepository<Village>
    {
        IEnumerable<Village> GetVillageById(int villageId);
        int SaveChanges();
    }
}
