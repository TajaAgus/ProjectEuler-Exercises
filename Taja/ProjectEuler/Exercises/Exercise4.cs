namespace ProjectEuler.Exercises
{
    public static class Exercise4
    {
        /*
         A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         Find the largest palindrome made from the product of two 3-digit numbers.
        */
        public static void Run()
        {
            const int MAX_VALUE = 1000;
            const int MIN_VALUE = 100;
            int palindromicNumber = 0;
            int product;
            int auxProduct;
            int digit;
            int numberToEvaluate;
            string numberString;

            for (int i = MIN_VALUE; i < MAX_VALUE; i++)
            {
                for (int j = i; j < MAX_VALUE; j++)
                {
                    numberString = "";
                    product = i * j;
                    auxProduct = product;

                    while (auxProduct > 0)
                    {
                        digit = auxProduct % 10;
                        auxProduct /= 10;

                        if (digit >= 0)
                            numberString += "" + digit;
                    }

                    numberToEvaluate = Int32.Parse(numberString);

                    if (numberToEvaluate == product && numberToEvaluate > palindromicNumber)
                    {
                        palindromicNumber = product;
                    }
                }
            }

            Console.WriteLine("El número capicúa más grande es: " + palindromicNumber);
        }
    }
}
