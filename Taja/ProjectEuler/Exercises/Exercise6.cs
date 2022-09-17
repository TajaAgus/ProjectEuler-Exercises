namespace ProjectEuler.Exercises
{
    public static class Exercise6
    {
        /*
        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        */
        public static void Run()
        {
            const int MAX_VALUE = 100;
            int sumOfTheSquares = 0;
            int squareOfTheSum = 0;
            int result;

            for (int i = 1; i <= MAX_VALUE; i++)
            {
                sumOfTheSquares += i * i;
            }

            for (int i = 1; i <= MAX_VALUE; i++)
            {
                squareOfTheSum += i;
            }

            squareOfTheSum *= squareOfTheSum;
            result = squareOfTheSum - sumOfTheSquares;

            Console.WriteLine(result.ToString());
        }
    }
}
