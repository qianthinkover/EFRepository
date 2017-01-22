using ProjectEntityFramework.Interfaces;
using ProjectEntityFrameworkService.DBEntities;
using System.Data.Entity;

namespace ProjectEntityFrameworkService
{
    public class EtntityDbContext : DbContext, IDbContext
    {
        public DbSet<User> Users { get; set; }

    }
}