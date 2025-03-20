using System.Numerics;

namespace GridProject.GridComponents
{
    public class GridCell
    {
        public Vector2 CellLocation { get; set; }

        public GridCell(int X, int Y)
        {
            CellLocation = new(X, Y);
        }

        public override string ToString()
        {
            return $"[{CellLocation.X},{CellLocation.Y}]";
        }
    }
}
