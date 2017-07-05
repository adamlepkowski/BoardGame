namespace BoardGame
{
    public class Piece : IPiece
    {
        private readonly int _y;
        private readonly int _x;
        private readonly Direction _direction;

        public Piece(int y, int x, Direction direction)
        {
            _y = y;
            _x = x;
            _direction = direction;
        }

        public string CurrentPosition => $"{this._x} {this._y} {this._direction}";
    }
}