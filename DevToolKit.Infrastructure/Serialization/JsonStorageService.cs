using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace DevToolKit.Infrastructure.Serialization
{
    public class JsonStorageService
    {
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
                LogManager.Current.LogError("Failed to Load Questions", ex);
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
                LogManager.Current.LogError("Failed to Save Questions", ex);
            }
        }
    }
}
