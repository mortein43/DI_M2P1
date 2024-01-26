using System.Xml.Serialization;

namespace DI_M2P1.Services;

public class FigureFileService
{
    public void SaveFiguresToFile<T>(T[] shapes, string filePath)
    {
        var serializer = new XmlSerializer(typeof(T[]));
        using (var writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, shapes);
        }

    }

    // Завантаження масиву фігур з файлу
    public T[] LoadFiguresFromFile<T>(string filePath)
    {
        var serializer = new XmlSerializer(typeof(T[]));
        using (var reader = new StreamReader(filePath))
        {
            return (T[])serializer.Deserialize(reader);
        }
    }
}
