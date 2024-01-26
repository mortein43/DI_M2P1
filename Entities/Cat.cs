using DI_M2P1.Repositories;

namespace DI_M2P1.Entities;

public class Cat : Animal
{
    public Cat() : base(null) { }
    public Cat(ILoggerForAnimal logger) : base(logger) { }

    public override string GetAnimalName()
    {
        return "Кіт";
    }
    public override string MakeSound()
    {
        return "Мяу! Мяу! Мяу!";
    }
}
