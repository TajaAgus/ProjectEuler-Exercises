using ProjectEuler.Utilities;

namespace ProjectEuler.Exercises
{
    public static class Exercise7
    {
        /*
        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        What is the 10 001st prime number?
        */
        public static void Run()
        {
            const int MAX_VALUE = 10001;
            int primeCounter = 1;
            int num = 1;

            while (primeCounter < MAX_VALUE)
            {
                num += 2;

                if (IsPrime.Run(num))
                {
                    primeCounter++;
                }
            }

            Console.WriteLine("El número primo 10001 es: " + num);
        }
    }
}
