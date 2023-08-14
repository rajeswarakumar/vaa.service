using Microsoft.EntityFrameworkCore;
using VillageAdminApp.API.Infrastructure.Database;
using VillageAdminApp.API.Model;

namespace VillageAdminApp.API.Infrastructure.Repositories
{
    public class VillageRepository : Repository<Village>, IVillageRepository
    {
        private readonly VillageDBContext _context;

        public VillageRepository(VillageDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Model.Village> GetVillageById(int villageId)
        {
            return _context.Villages.Where(V => V.Id == villageId);
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }        
    }
}
