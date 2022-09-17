namespace ProjectEuler.Exercises
{
    public static class Exercise5
    {
        /*
         2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */
        public static void Run()
        {
            long number = 20;
            double quotient;

            for (double i = 2; i <= 20; i++)
            {
                quotient = number / i;

                if (quotient % 1 != 0)
                {
                    i = 2;
                    number++;
                }
            }

            Console.WriteLine("El número divisible por todos los numeros desde el 1 al 20 es: " + number);
        }
    }
}
