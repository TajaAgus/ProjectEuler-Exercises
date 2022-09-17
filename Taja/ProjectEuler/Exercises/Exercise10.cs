using ProjectEuler.Utilities;

namespace ProjectEuler.Exercises
{
    public static class Exercise10
    {
        /*
        The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        Find the sum of all the primes below two million.
        */
        public static void Run()
        {
            const int MAX_VALUE = 2000000;

            long result = 17;

            for (int i = 11; i < MAX_VALUE; i += 2)
            {
                if (IsPrime.Run(i))
                    result += i;
            }

            Console.WriteLine("La suma de los números primos es: " + result);
        }
    }
}
