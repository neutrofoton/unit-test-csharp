using System;
using Microsoft.Extensions.Configuration;
using NeutroLab.BusinessLogic.Config;
using NeutroLab.XUnit.JsonConfiguration;

namespace NeutroLab.BusinessLogic.Test.ConfigurationTest
{
    public class DbConfigurationReader : ConfigurationReader
    {
        public DbConfiguration GetDbConfiguration(string basePath)
        {
            var configuration = new DbConfiguration();
            var iConfigRoot = GetConfigurationRoot(basePath);

            iConfigRoot
                .GetSection("DbConfiguration")
                .Bind(configuration);

            return configuration;
        }
    }
}
