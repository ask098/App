using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Wayuu.Helpers
{
    public static class HelperConfiguration
    {
        public static AppConfiguration GetAppConfiguration
            (string configurationFile = "App.json")
        {
            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile(configurationFile, optional: false)
                .Build();
            var Result = Configuration.Get<AppConfiguration>();
            return Result;
        }
    }
}

