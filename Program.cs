using DI_M2P1.Entities;
using DI_M2P1.Repositories;
using DI_M2P1.Services;

namespace DI_M2P1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Завдання 1:");
        var consoleLogger = new ConsoleLoggerForAnimal();
        var dog = new Dog(consoleLogger);
        var cat = new Cat(consoleLogger);

        var dogService = new AnimalService(dog, consoleLogger);
        var catService = new AnimalService(cat, consoleLogger);

        dogService.DisplayAnimalInfo();
        catService.DisplayAnimalInfo();

        var fileLogger = new FileLoggerForAnimal("log.txt");
        var dogWithFileLogger = new Dog(fileLogger);
        var catWithFileLogger = new Cat(fileLogger);

        var dogServiceWithFileLogger = new AnimalService(dogWithFileLogger, fileLogger);
        var catServiceWithFileLogger = new AnimalService(catWithFileLogger, fileLogger);

        dogServiceWithFileLogger.DisplayAnimalInfo();
        catServiceWithFileLogger.DisplayAnimalInfo();

        Console.WriteLine("Завдання 2:");
        var animalFileService = new AnimalFileService();
        var animals = new Animal[]
        {
            dog,
            cat,
        };

        animalFileService.SaveToFile(animals, "animals.xml");
        var loadedAnimals = animalFileService.LoadFromFile<Animal>("animals.xml");
        foreach (var loadedAnimal in loadedAnimals)
        {
            var loadedAnimalService = new AnimalService(loadedAnimal, consoleLogger, animalFileService);
            loadedAnimalService.DisplayAnimalInfo();
        }
        Console.WriteLine("Завдання 3:");

        var circle = new Circle(consoleLogger);
        var rectangle = new Rectangle(consoleLogger);

        var circleService = new FigureService(circle, consoleLogger);
        circleService.DisplayFigureInfo();

        var rectangleService = new FigureService(rectangle, consoleLogger);
        rectangleService.DisplayFigureInfo();

        circleService = new FigureService(circle, fileLogger);
        circleService.DisplayFigureInfo();

        rectangleService = new FigureService(rectangle, fileLogger);
        rectangleService.DisplayFigureInfo();

        Console.WriteLine("Завдання 4:");

        var figures = new Figure[] { circle, rectangle };
        var figureFileService = new FigureFileService();
        figureFileService.SaveFiguresToFile(figures, "figures.xml");

        var loadedShapes = figureFileService.LoadFiguresFromFile<Figure>("figures.xml");

        foreach (var loadedShape in loadedShapes)
        {
            var loadedShapeService = new FigureService(loadedShape, consoleLogger);
            loadedShapeService.DisplayFigureInfo();
        }
    }
}
