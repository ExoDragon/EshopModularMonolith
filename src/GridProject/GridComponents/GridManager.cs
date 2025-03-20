using System.Numerics;

namespace GridProject.GridComponents;

public class GridManager
{
    public Grid CurrentGrid { get; set; } = new();

    public void GenerateGrid(Vector2 gridSize)
    {
        CurrentGrid = new Grid();


    }
}
