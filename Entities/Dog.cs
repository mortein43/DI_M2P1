using DI_M2P1.Repositories;

namespace DI_M2P1.Entities;

public class Dog : Animal
{
    public Dog() : base(null) { }
    public Dog(ILoggerForAnimal logger) : base(logger) { }

    public override string GetAnimalName()
    {
        return "Пес";
    }
    public override string MakeSound()
    {
        return "Гав! Гав!";
    }
}
