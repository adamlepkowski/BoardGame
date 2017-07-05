namespace BoardGame
{
    public interface IPiece
    {
        IPosition CurrentPosition { get; set; }

        void RotateRight();

        void RotateLeft();

        void Move(IBoard board);
    }
}