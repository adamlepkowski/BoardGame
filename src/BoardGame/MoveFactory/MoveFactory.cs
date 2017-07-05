using System.Collections.Generic;
using BoardGame.MoveStrategies;

namespace BoardGame.MoveFactory
{
    public class MoveFactory : IMoveFactory
    {
        private readonly Dictionary<Direction, IMove> _movements;

        public MoveFactory()
        {
            _movements = new Dictionary<Direction, IMove>()
            {
                {Direction.N, new MoveNorth() },
                {Direction.E, new MoveEast() },
                {Direction.S, new MoveSouth() },
                {Direction.W, new MoveWest() }
            };
        }

        public IMove CreateMove(Direction direction)
        {
            return _movements[direction];
            // TODO: throw exception when direction not available in dictionary
        }
    }
}