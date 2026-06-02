using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using DevToolkit.Core.Results;

namespace DevToolkit.Infrastructure.Serialization
{
    public class JsonSerializerProvider : ISerialization
    {
        public Result<T> Deserialize<T>(string path) where T : new()
        {
            try
            {
                T obj = new T();
                if (!File.Exists(path))
                {
                    LogManager.LogWarning($"File Not Found at {path}, Creating New File");

                    Serialize<T>(path, obj);
                    return Result<T>.Success(obj);
                }

                string Json = File.ReadAllText(path);
                return Result<T>.Success(JsonSerializer.Deserialize<T>(Json));
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to Load Questions", ex);
                return Result<T>.Failure("Failed to Load Questions");
            }
        }

        public Result Serialize<T>(string path, T obj) where T : new()
        {
            try
            {
                string Json = JsonSerializer.Serialize<T>(
                    obj, 
                    new JsonSerializerOptions 
                    {
                        WriteIndented = true 
                    });
                File.WriteAllText(path, Json);

                LogManager.LogInfo("Obj Serialized Successfully");

                return Result.Success();
            }
            catch (Exception ex)
            {
                LogManager.LogError("Failed to Save Obj", ex);
                return Result.Failure("Failed to Save Obj");
            }
        }
    }
}
