namespace BoardGame
{
    public class Position : IPosition
    {
        public Position(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int Y { get; set; }
        public int X { get; set; }
    }
}