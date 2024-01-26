using DI_M2P1.Repositories;

namespace DI_M2P1.Entities;

public class Circle : Figure
{
    public Circle() : base(null) { }
    public Circle(ILoggerForAnimal display) : base(display) { }

    public override string Display()
    {
        return "\n  ***\n *   *\n *   *\n  ***";
    }

    public override string GetFigureName()
    {
        return "Коло";
    }
}
