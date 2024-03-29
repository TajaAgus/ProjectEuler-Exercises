﻿using System.Reflection.Metadata;

namespace ProjectEuler.Exercises
{
    public static class Exercise8
    {
        /*
        The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.
        (GIANT NUMBER)
        Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        */

        const string NUMBERS_STRING = "731671765313306249192251196744265747423553491949349698352031277450632623957831801698480" +
                "18694788518438586156078911294949545950173795833195285320880551112540698747158523863050715693290963295227443043557668966489504" +
                "4524452316173185640309871112172238311362229893423380308135336276614282806444486645238749303589072962904915604407723907138105158593079" +
                "6086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958" +
                "6446706324415722155397536978179778461740649551492908625693219784686224828397224137565705605749026140797296865241453510047482166370484" +
                "4031998900088952434506585412275886668811642717147992444292823086346567481391912316282458617866458359124566529476545682848912883142607" +
                "6900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992" +
                "005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        const int LIMIT = 1000;
        const int ADJ_NUMBERS = 13;

        public static void Run()
        {
            long product;
            long result = 0;
            int index = 0;

            for (int i = 0; index < LIMIT; i++)
            {
                product = 1;
                for (int j = 0; j < ADJ_NUMBERS && product != 0; j++)
                {
                    index = i + j;
                    if (index < LIMIT)
                    {
                        product *= (int)Char.GetNumericValue((char)NUMBERS_STRING[index]);
                    }
                }
                if (product != 0 && product > result)
                {
                    result = product;
                }
            }
            Console.WriteLine("El valor del producto más alto es: " + result);
        }
    }
}
