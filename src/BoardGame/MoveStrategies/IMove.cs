namespace BoardGame.MoveStrategies
{
    public interface IMove
    {
        IPosition GetNewPosition(IPosition position);
    }
}