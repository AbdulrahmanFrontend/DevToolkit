using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Serialization
{
    public class SerializationManager
    {
        public static ISerialization Current { get; set; } = new JsonSerializerProvider();

        public static Result<T> Deserialize<T>(string path) where T : new()
            => (Current == null) ? Result<T>.Failure("No serialization provider available") 
            : Current.Deserialize<T>(path);

        public static Result Serialize<T>(string path, T obj) where T : new()
            => Current?.Serialize<T>(path, obj) ?? 
            Result.Failure("No serialization provider available");
    }
}
