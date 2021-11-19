namespace TaskC
{
    class DistanceRenderer
    {
        public void Display(int distance, int serialNumberOfFirstSelectedNumber, int serialNumberOfSecondSelectedNumber)
        {
            Console.WriteLine("\nСамая маленькая дистанция между числами: " + distance);
            Console.WriteLine("Порядковый номер первого числа: " + serialNumberOfFirstSelectedNumber);
            Console.WriteLine("Порядковый номер второго числа: " + serialNumberOfSecondSelectedNumber);
        }
    }
}