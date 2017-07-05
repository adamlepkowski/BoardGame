using BoardGame.MoveStrategies;

namespace BoardGame.MoveFactory
{
    public class MoveSouth : IMove
    {
        public IPosition GetNewPosition(IPosition position)
        {
            return new Position(position.Y - 1, position.X);
        }
    }
}