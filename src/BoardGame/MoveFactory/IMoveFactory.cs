using System.Security.Cryptography.X509Certificates;
using BoardGame.MoveStrategies;

namespace BoardGame.MoveFactory
{
    public interface IMoveFactory
    {
        IMove CreateMove(Direction direction);
    }
}