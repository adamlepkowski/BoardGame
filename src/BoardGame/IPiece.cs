namespace BoardGame
{
    public interface IPiece
    {
        string CurrentPosition { get; }

        void RotateRight();

        void RotateLeft();
    }
}