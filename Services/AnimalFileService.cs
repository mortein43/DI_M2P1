using System.Xml.Serialization;

namespace DI_M2P1.Services;

public class AnimalFileService
{
    public void SaveToFile<T>(T[] animals, string filePath)
    {
        var serializer = new XmlSerializer(typeof(T[]));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, animals);
        }
    }

    public T[] LoadFromFile<T>(string filePath)
    {
        var serializer = new XmlSerializer(typeof(T[]));
        using (var reader = new StreamReader(filePath))
        {
            return (T[])serializer.Deserialize(reader);
        }
    }
}
