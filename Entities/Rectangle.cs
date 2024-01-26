using DI_M2P1.Repositories;

namespace DI_M2P1.Entities;

public class Rectangle : Figure
{
    public Rectangle() : base(null) { }
    public Rectangle(ILoggerForAnimal display) : base(display) { }

    public override string Display()
    {
        return "\t\t\t\n******\t\t\t\n*    *\t\t\t\n******";
    }

    public override string GetFigureName()
    {
        return "Прямокутник";
    }
}
