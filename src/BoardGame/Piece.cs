
using System;
using BoardGame.MoveFactory;

namespace BoardGame
{
    public class Piece : IPiece
    {
        public Direction Direction { get; set; }
        private readonly IMoveFactory _moveFactory = new MoveFactory.MoveFactory();

        public Piece(IPosition currentPosition, Direction direction)
        {
            CurrentPosition = currentPosition;
            Direction = direction;
        }

        public IPosition CurrentPosition { get; set; }

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

        public void Move(IBoard board)
        {
            if (board == null)
            {
                throw new ArgumentNullException(nameof(board));
            }

            var move = this._moveFactory.CreateMove(this.Direction);

            var newPosition = move.GetNewPosition(this.CurrentPosition);

            if (board.IsPositionValid(newPosition))
            {
                this.CurrentPosition.Y = newPosition.Y;
                this.CurrentPosition.X = newPosition.X;
            }
        }

        public override string ToString()
        {
            return $"{this.CurrentPosition.X} {this.CurrentPosition.Y} {this.Direction}";
        }
    }
}