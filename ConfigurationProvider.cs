using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Configuration;

namespace AppiumSpecflowSample
{
    public class ConfigurationProvider
    {
        private readonly IConfiguration _configuration;
        //default path will load Android Production settings
        public static string appPath = "appsettings_androidProduction.json";
        public Settings GetSettings()
        {
            return _configuration.Get<Settings>();
        }
        public ConfigurationProvider()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "appsettings_androidProduction.json", false, true)
                .Build();
        }
    }
}
