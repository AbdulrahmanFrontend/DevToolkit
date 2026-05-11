using DevToolkit.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace DevToolKit.Infrastructure
{
    public class clsCacheManager
    {
        public static Dictionary<string, string> Cache =
            new Dictionary<string, string>();
        private static readonly string _FilePath = "QueryCache.json";
        private static void _LoadCache()
        {
            try
            {
                if (File.Exists(_FilePath))
                {
                    var Json = File.ReadAllText(_FilePath);
                    Cache = JsonSerializer.Deserialize<Dictionary<string, string>>(Json)
                        ?? new Dictionary<string, string>();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Failed to load cache;", ex);
            }
        }
        static clsCacheManager()
        {
            _LoadCache();
        }
        public static void SaveCache()
        {
            try
            {
                var Json = JsonSerializer.Serialize(Cache);
                File.WriteAllText(_FilePath, Json);
            }
            catch (Exception ex)
            {
                Logger.LogError("Failed to save cache;", ex);
            }
        }

        public static void Load<T>(T Cache, string FilePath) where T : new()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    Cache = new T();
                    Save<T>(Cache, FilePath);
                    return;
                }
                string Json = File.ReadAllText(FilePath);
                Cache = JsonSerializer.Deserialize<T>(Json);
            }
            catch (Exception ex)
            {
                Logger.LogError("Failed to Load Questions", ex);
            }
        }

        public static void Save<T>(T Cache, string FilePath)
        {
            try
            {
                string Json = JsonSerializer.Serialize<T>(Cache);
                File.WriteAllText(FilePath, Json);
            }
            catch (Exception ex)
            {
                Logger.LogError("Failed to Save Questions", ex);
            }
        }
    }
}
