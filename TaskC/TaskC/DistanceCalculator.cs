namespace TaskC
{
    class DistanceCalculator
    {
        private int _serialNumberOfFirstSelectedNumber = 0;
        private int _serialNumberOfSecondSelectedNumber = 0;

        public int SerialNumberOfFirstSelectedNumber => _serialNumberOfFirstSelectedNumber;
        public int SerialNumberOfSecondSelectedNumber => _serialNumberOfSecondSelectedNumber;

        public int GetSmallestDistanceFrom(Point[] points)
        {
            int smallestDistance = 110;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int distance = Vector.Distance(points[i], points[j]);

                    if(distance < 0)
                    {
                        distance = Vector.Distance(points[j], points[i]);
                    }

                    if (distance < smallestDistance)
                    {
                        smallestDistance = distance;
                        _serialNumberOfFirstSelectedNumber = i + 1;
                        _serialNumberOfSecondSelectedNumber = j + 1;
                    }
                }
            }

            return smallestDistance;
        }
    }
}