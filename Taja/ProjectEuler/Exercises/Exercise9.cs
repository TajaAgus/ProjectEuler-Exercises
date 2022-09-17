namespace ProjectEuler.Exercises
{
    public static class Exercise9
    {
        /*
        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a2 + b2 = c2
        For example, 32 + 42 = 9 + 16 = 25 = 52.
        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
        */
        
        /* Formulas:
        a * a + b * b = c * c 
        a = p * p - q * q
        b = 2 * p * q
        c = p * p + q * q
        */
        public static void Run()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            int p = 1;
            int q;

            bool found = false;
            long result;

            while (!found)
            {
                q = 1;
                p++;
                a = p * p - q * q;
                b = 2 * (p * q);
                c = p * p + q * q;
                if (a + b + c == 1000) 
                    found = true;
                else while (q < p && !found)
                    {
                        q++;
                        a = p * p - q * q;
                        b = 2 * p * q;
                        c = p * p + q * q;
                        if (a + b + c == 1000) 
                            found = true;
                    }
            }

            result = a * b * c;

            Console.WriteLine("El producto del triplete pitagorico es: " + result);
        }
    }
}
