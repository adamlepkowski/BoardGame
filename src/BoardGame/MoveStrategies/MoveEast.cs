using BoardGame.MoveStrategies;

namespace BoardGame.MoveFactory
{
    public class MoveEast : IMove
    {
        public IPosition GetNewPosition(IPosition position)
        {
            return new Position(position.Y, position.X + 1);
        }
    }
}