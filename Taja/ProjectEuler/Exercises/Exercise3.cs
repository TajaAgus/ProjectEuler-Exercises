using ProjectEuler.Utilities;

namespace ProjectEuler.Exercises
{
    public static class Exercise3
    {
        /*
         The prime factors of 13195 are 5, 7, 13 and 29.
         What is the largest prime factor of the number 600851475143?
        */
        public static void Run()
        {
            const long VALUE = 600851475143;
            int i;
            long product = 1;

            for (i = 2; product != VALUE; i++)
            {
                if (IsPrime.Run(i))
                {
                    if (VALUE % i == 0)
                        product *= i;
                }
                
            }

            Console.WriteLine("El factor primo más grande es: " + (i - 1));
        }
    }
        
}
