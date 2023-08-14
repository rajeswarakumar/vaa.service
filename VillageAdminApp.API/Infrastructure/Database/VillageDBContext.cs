using Microsoft.EntityFrameworkCore;
using VillageAdminApp.API.Model;

namespace VillageAdminApp.API.Infrastructure.Database
{
    public class VillageDBContext : DbContext
    {
        public VillageDBContext(DbContextOptions<VillageDBContext> options) : base(options)
        {

        }

        public DbSet<Village> Villages { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Taluk> Taluks { get; set; }

    }
}
