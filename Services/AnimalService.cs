using DI_M2P1.Entities;
using DI_M2P1.Repositories;

namespace DI_M2P1.Services;

public class AnimalService
{
    private readonly Animal animal;
    private readonly ILoggerForAnimal logger;
    private readonly AnimalFileService fileService;
    public AnimalService(Animal animal, ILoggerForAnimal logger)
    {
        this.animal = animal;
        this.logger = logger;
    }
    public AnimalService(Animal animal, ILoggerForAnimal logger, AnimalFileService fileService)
    {
        this.animal = animal;
        this.logger = logger;
        this.fileService = fileService;
    }

    public void DisplayAnimalInfo()
    {
        logger.Log($"Назва: {animal.GetAnimalName()}");
        logger.Log($"Звук: {animal.MakeSound()}");
    }
}
