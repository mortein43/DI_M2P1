using DI_M2P1.Entities;
using DI_M2P1.Repositories;

namespace DI_M2P1.Services;

public class FigureService
{
    private readonly Figure figure;
    private readonly ILoggerForAnimal display;

    public FigureService(Figure figure, ILoggerForAnimal display)
    {
        this.figure = figure;
        this.display = display;
    }

    public void DisplayFigureInfo()
    {
        display.Log($"Фігура: {figure.GetFigureName()}");
        display.Log($"Вигляд: {figure.Display()}");

    }
}
