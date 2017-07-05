namespace BoardGame
{
    public class Board
    {
        private const int Hight = 5;
        private const int Width = 5;

        public Board()
        {
            Piece = new Piece(0, 0, Direction.N);
        }

        public IPiece Piece { get; private set; }
    }
}