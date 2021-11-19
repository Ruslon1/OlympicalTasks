using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество точек(3<n<106): ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length is < 3 or > 105)
            {
                Console.WriteLine("Проверьте правильность ввода");
                return;
            }

            var distanceCalculator = new DistanceCalculator();
            var distanceRenderer = new DistanceRenderer();

            Point[] points = new Point[length];

            Random random = new Random();

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = random.Next(109);
                Console.Write(points[i].X + " ");
            }

            int smallestDistance = distanceCalculator.GetSmallestDistanceFrom(points);

            distanceRenderer.Display(smallestDistance,
                distanceCalculator.SerialNumberOfFirstSelectedNumber, 
                distanceCalculator.SerialNumberOfSecondSelectedNumber);
        }
    }
}