using AppWithDbSettingsProvider.Config.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppWithDbSettingsProvider.Config.Data
{
    public class SettingsDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }

        public SettingsDbContext(DbContextOptions<SettingsDbContext> options)
            : base(options)
        {
        }
    }
}
