namespace DI_M2P1.Repositories;

public class ConsoleLoggerForAnimal : ILoggerForAnimal
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
