using DI_M2P1.Repositories;
using System.Xml.Serialization;

namespace DI_M2P1.Entities;

[Serializable]
[XmlInclude(typeof(Circle))]
[XmlInclude(typeof(Rectangle))]
public abstract class Figure
{
    public readonly ILoggerForAnimal display;
    public Figure(ILoggerForAnimal display)
    {
        this.display = display;
    }

    public abstract string GetFigureName();
    public abstract string Display();
}
