using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter_DataAccessLayer.Global_classes
{
    internal class clsDataAccessSettings
    {
        private static IConfigurationRoot? _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static string? ConnectionString = _configuration.GetSection("ConnectionString").Value;
    }
}
