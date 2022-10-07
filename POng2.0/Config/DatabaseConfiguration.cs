using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Config
{
    public class DatabaseConfiguration
    {
        public static IConfigurationRoot Configuration { get; set; }
        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
            string conn = Configuration["ConnectionStrings:DefaultConnection"];
            return conn;
        }
    }
}
