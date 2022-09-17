namespace ProjectEuler.Utilities
{
    public static class IsPrime
    {
        public static bool Run(int num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            int counter = 3;

            while ((counter * counter) <= num)
            {
                if (num % counter == 0)
                    return false;
                else
                    counter += 2;
            }

            return true;
        }
    }
}
