namespace GridProject.GridComponents;

public class GridFloor
{
    public List<GridRow> GridRows { get; set; } = [];

    public void AddGridRow(GridRow gridRow) => GridRows.Add(gridRow);
}
