using System;
using Microsoft.Extensions.Configuration;

namespace NeutroLab.XUnit.JsonConfiguration
{
    public class ConfigurationReader
    {
        public IConfigurationRoot GetConfigurationRoot(string basePath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
