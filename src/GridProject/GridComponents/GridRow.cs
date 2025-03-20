namespace GridProject.GridComponents;

public class GridRow
{
    public List<GridCell> GridCells { get; set; } = [];

    public void AddGridCell(GridCell gridCell) => GridCells.Add(gridCell);
}
