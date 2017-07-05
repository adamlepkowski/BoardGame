namespace BoardGame
{
    public class Piece : IPiece
    {
        public Direction Direction { get; set; }
        private readonly int _y;
        private readonly int _x;

        public Piece(int y, int x, Direction direction)
        {
            _y = y;
            _x = x;
            Direction = direction;
        }
        
        public string CurrentPosition => $"{this._x} {this._y} {this.Direction}";

        public void RotateRight()
        {
            if (this.Direction == Direction.W)
            {
                this.Direction = Direction.N;
            }
            else
            {
                this.Direction++;
            }
        }

        public void RotateLeft()
        {
            if (this.Direction == Direction.N)
            {
                this.Direction = Direction.W;
            }
            else
            {
                this.Direction--;
            }
        }
    }
}