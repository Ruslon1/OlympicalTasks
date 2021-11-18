namespace TaskB
{
    class ChessBoard
    {
        private int _widthItemCount;
        private int _lengthItemCount;

        public ChessBoard(int widthItemCount, int lengthItemCount)
        {
            _widthItemCount = widthItemCount;
            _lengthItemCount = lengthItemCount;
        }

        public void ShowBlackIntemsCount()
        {
            Console.WriteLine("Черных клеток: " + CalculateBlackIntemsCount());
        }

        private int CalculateBlackIntemsCount()
        {
            return (_widthItemCount * _lengthItemCount) / 2;
        }
    }
}