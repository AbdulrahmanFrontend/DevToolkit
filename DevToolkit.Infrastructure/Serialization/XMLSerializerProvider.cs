using DevToolkit.Logging.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DevToolkit.Core.Results;

namespace DevToolkit.Infrastructure.Serialization
{
    public class XMLSerializerProvider : ISerialization
    {
        public Result<T> Deserialize<T>(string path) where T : new()
        {
            try
            {
                T obj = new T();
                if (!File.Exists(path))
                {
                    LogManager.LogWarning("The specified XML file does not exist. " +
                        "A new instance of the object will be created and saved to the file.");

                    Serialize<T>(path, obj);
                    return Result<T>.Success(obj);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                    obj = (T)serializer.Deserialize(fileStream);

                return Result<T>.Success(obj);
            }
            catch (Exception ex)
            {
                LogManager.LogError("An error occurred while deserializing the XML file.", ex);
                return Result<T>.Failure("An error occurred while deserializing the XML file.");
            }
        }

        public Result Serialize<T>(string path, T obj) where T : new()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                    serializer.Serialize(fileStream, obj);

                LogManager.LogInfo("Object successfully serialized to XML.");

                return Result.Success();
            }
            catch (Exception ex)
            {
                LogManager.LogError("An error occurred while serializing the object to XML.", ex);
                return Result.Failure("An error occurred while serializing the object to XML.");
            }
        }
    }
}
