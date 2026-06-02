using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Infrastructure.Serialization
{
    public interface ISerialization
    {
        Result<T> Deserialize<T>(string path) where T : new();

        Result Serialize<T>(string path, T obj) where T : new();
    }
}
