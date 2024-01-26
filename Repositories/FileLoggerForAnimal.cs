namespace DI_M2P1.Repositories;

public class FileLoggerForAnimal : ILoggerForAnimal
{
    private readonly string filePath;
    public FileLoggerForAnimal(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath, $"{message}\n");
    }
}
