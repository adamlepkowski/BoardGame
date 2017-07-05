using BoardGame.MoveStrategies;

namespace BoardGame.MoveFactory
{
    public class MoveWest : IMove
    {
        public IPosition GetNewPosition(IPosition position)
        {
            return new Position(position.Y, position.X - 1);
        }
    }
}