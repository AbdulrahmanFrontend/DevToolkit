using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Registry
{
    public class RegistryConfiguration
    {
        public static string CompanyName { get; set; } = "DevToolkit";

        public static string ApplicationName { get; set; } = "App";

        public static RegistryHive Hive { get; set; } = RegistryHive.CurrentUser;

        public static string BasePath =>
            $@"SOFTWARE\{CompanyName}\{ApplicationName}";
    }
}
