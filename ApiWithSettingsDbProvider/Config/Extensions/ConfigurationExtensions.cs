using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace AppWithDbSettingsProvider.Config.Extensions
{
    internal static class ConfigurationExtensions
    {
        internal static IConfigurationBuilder AddSettingsDbProvider(this IConfigurationBuilder configuration, Action<DbContextOptionsBuilder> setup)
        {
            configuration.Add(new SettingsDbSource(setup));

            return configuration;
        }
    }
}
