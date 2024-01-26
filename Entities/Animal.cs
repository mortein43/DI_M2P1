using DI_M2P1.Repositories;
using System.Xml.Serialization;

namespace DI_M2P1.Entities;

[Serializable]
[XmlInclude(typeof(Dog))]
[XmlInclude(typeof(Cat))]
public abstract class Animal
{
    public readonly ILoggerForAnimal logger;

    public Animal(ILoggerForAnimal logger)
    {
        this.logger = logger;
    }

    public abstract string GetAnimalName();
    public abstract string MakeSound();
}
