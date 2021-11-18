namespace TaskB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите ширину доски(< 109): ");
            int widthItemCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину доски(> 0): ");
            int lengthItemCount = Convert.ToInt32(Console.ReadLine());

            if (widthItemCount >= 109 || lengthItemCount < 1)
            {
                Console.WriteLine("Проверьте правильность ввода");
                return;
            }

            var chessBoard = new ChessBoard(widthItemCount, lengthItemCount);

            chessBoard.ShowBlackIntemsCount();
        }
    }
}