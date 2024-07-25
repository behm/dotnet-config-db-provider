using AppWithDbSettingsProvider.Config.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AppWithDbSettingsProvider.Config
{
    public class SettingsDbProvider : ConfigurationProvider, IConfigurationProvider
    {
        private readonly Action<DbContextOptionsBuilder> _options;

        public SettingsDbProvider(Action<DbContextOptionsBuilder> options)
        {
            _options = options;
        }

        public override void Load()
        {
            var builder = new DbContextOptionsBuilder<SettingsDbContext>();
            _options(builder);

            using (var context = new SettingsDbContext(builder.Options))
            {
                var items = context.Settings
                    .AsNoTracking()
                    .ToList();

                foreach (var item in items)
                {
                    Data.Add(item.Key, item.Value);
                }
            }
        }
    }
}
