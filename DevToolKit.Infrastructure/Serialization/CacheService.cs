using DevToolkit.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DevToolKit.Infrastructure.Serialization
{
    public class CacheService
    {
        public static Dictionary<string, string> Cache =
            new Dictionary<string, string>();
        private static readonly string _FilePath = "QueryCache.json";
        private static void _LoadCache()
        {
            JsonStorageService.Load<Dictionary<string, string>>(Cache, _FilePath);
        }
        static CacheService()
        {
            _LoadCache();
        }
        public static void SaveCache()
        {
            JsonStorageService.Save<Dictionary<string, string>>(Cache, _FilePath);
        }
    }
}
