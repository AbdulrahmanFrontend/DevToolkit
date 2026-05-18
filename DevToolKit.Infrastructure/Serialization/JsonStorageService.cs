using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace DevToolKit.Infrastructure.Serialization
{
    public class JsonStorageService
    {
        public static T Load<T>(string FilePath) where T : new()
        {
            T Cache = new T();
            try
            {
                if (!File.Exists(FilePath))
                {
                    Save<T>(Cache, FilePath);
                    return Cache;
                }
                string Json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<T>(Json);
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to Load Questions", ex);
                return new T();
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
                LogManager.LogError("Failed to Save Questions", ex);
            }
        }
    }
}
