namespace BoardGame
{
    public class Board
    {
        private const int Hight = 5;
        private const int Width = 5;

        public Board()
        {
            this.Piece = new Piece(0, 0, Direction.N);
        }

        public IPiece Piece { get; private set; }

        public void MovePiece(string commands)
        {
            foreach (var command in commands.ToUpper())
            {
                switch (command)
                {
                    case 'L':
                        this.Piece.RotateLeft();
                        break;
                    case 'R':
                        this.Piece.RotateRight();
                        break;
                }
            }
        }
    }
}