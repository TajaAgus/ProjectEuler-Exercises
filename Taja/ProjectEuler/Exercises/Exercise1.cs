namespace ProjectEuler.Exercises
{
    public static class Exercise1
    {
        /*
         If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         Find the sum of all the multiples of 3 or 5 below 1000.
        */
        public static void Run()
        {
            const int MAX_VALUE = 1000;

            int result3 = 0;
            int result5 = 0;
            int total = 0;

            for (int i = 1; result3 < MAX_VALUE; i++)
            {
                total += result3;

                result3 = i * 3;
            }

            for (int i = 1; result5 < MAX_VALUE; i++)
            {
                if (result5 % 3 != 0)
                    total += result5;

                result5 = i * 5;
            }

            Console.WriteLine("El resultado de la suma es: " + total);
        }
    }
}
