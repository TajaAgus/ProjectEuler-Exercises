using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ejercicio 1
        private void button1_Click(object sender, EventArgs e)
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
            MessageBox.Show(total.ToString());
        }

        //Ejercicio 2
        private void button2_Click(object sender, EventArgs e)
        {
            const int MAX_VALUE = 4000000;
            int number1 = 1;
            int number2 = 2;
            int aux;
            int result = 0;

            while (number2 < MAX_VALUE)
            {
                if (number1 % 2 == 0)
                    result += number1;

                if (number2 % 2 == 0)
                    result += number2;

                aux = number1 + number2;
                number1 = aux;
                aux = number1 + number2;
                number2 = aux;
            }
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 3
        private void button3_Click(object sender, EventArgs e)
        {
            const long VALUE = 600851475143;
            int i;
            long product = 1;

            for (i = 2; product != VALUE; i++)
            {
                if (VALUE % i  == 0)
                    product *= i;
            }
            MessageBox.Show("" + (i - 1));
        }

        //Ejercicio 4
        private void button4_Click(object sender, EventArgs e)
        {
            const int MAX_VALUE = 1000;
            const int MIN_VALUE = 100;
            int palindromicNumber = 0;
            int product;
            int product2;
            int number;
            int finalNumber;
            string numberString;

            for (int i = MIN_VALUE; i < MAX_VALUE; i++)
            {
                for (int j = i; j < MAX_VALUE; j++)
                {
                    numberString = "";
                    product = i * j;
                    product2 = product;

                    while (product2 > 0)
                    {
                        number = product2 % 10; 
                        product2 /= 10;

                        if (number >= 0)
                            numberString += "" + number;
                    }

                    finalNumber = Int32.Parse(numberString);

                    if (finalNumber == product && finalNumber > palindromicNumber)
                    {
                        palindromicNumber = product;
                    }
                }
            } 
            MessageBox.Show(palindromicNumber.ToString());
        }

        //Ejercicio 5
        private void button5_Click(object sender, EventArgs e)
        {
            long number = 20;
            double number2 = 0;
            for (double i = 2; i <= 20; i++)
            {
                number2 = number / i;
                if (number2 % 1 != 0)
                {
                    i = 2;
                    number++;
                }
            }
            MessageBox.Show(number.ToString());
        }

        //Ejercicio 6
        private void button6_Click(object sender, EventArgs e)
        {
            int sumOfTheSquares = 0;
            int squareOfTheSum = 0;
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfTheSquares += i * i;
            }
            for (int i = 1; i <= 100; i++)
            {
                squareOfTheSum += i; 
            }
            squareOfTheSum *= squareOfTheSum;
            result = squareOfTheSum - sumOfTheSquares;
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 7
        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            bool isPrime;
            int primeCounter = 0;
            for (i = 2; primeCounter != 10001; i++)
            {
                isPrime = true;
                for (int j = 2; j < i && isPrime; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primeCounter++;
            }
            MessageBox.Show((i - 1).ToString() );
        }
        
        //Ejercicio 8
        private void button8_Click(object sender, EventArgs e)
        {
            string numbersString = "731671765313306249192251196744265747423553491949349698352031277450632623957831801698480" + 
                "18694788518438586156078911294949545950173795833195285320880551112540698747158523863050715693290963295227443043557668966489504" + 
                "4524452316173185640309871112172238311362229893423380308135336276614282806444486645238749303589072962904915604407723907138105158593079" +
                "6086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958" +
                "6446706324415722155397536978179778461740649551492908625693219784686224828397224137565705605749026140797296865241453510047482166370484" +
                "4031998900088952434506585412275886668811642717147992444292823086346567481391912316282458617866458359124566529476545682848912883142607" +
                "6900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992" +
                "005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long product = 1;
            long result = 0;
            int index = 0;

            for (int i = 0; index <= 999; i++)
            {
                for (int j = 0; j <= 12 && product != 0; j++)
                {
                    index = i + j;
                    if (index <= 999)
                    {
                        product *= (int)Char.GetNumericValue((char)numbersString[index]);
                    }
                }
                if (product != 0 && product > result)
                {
                    result = product;
                }
                product = 1;
            }
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 9
        // a * a + b * b = c * c 
        // a = p * p - q * q
        // b = 2 * p * q
        // c = p * p + q * q
        private void button9_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 1;
            int c = 1;

            int p = 1;
            int q = 1;

            bool flag = true;

            long result;
            while (flag)
            {
                q = 1;
                p++;
                a = p * p - q * q;
                b = 2 * (p * q);
                c = p * p + q * q;
                if (a + b + c == 1000) flag = false;
                else while (q < p)
                    {
                        q++;
                        a = p * p - q * q;
                        b = 2 * p * q;
                        c = p * p + q * q;
                        if (a + b + c == 1000)
                        {
                            flag = false;
                            break;
                        }
                    }
            }
            result = a * b * c; 
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 10
        private void button10_Click(object sender, EventArgs e)
        {
            bool isPrime = true;
            bool preFilter = false;
            long result = 17;

            for (int i = 11; i < 2000000; i += 2)
            { 
                if (i % 5 == 0)
                {
                    preFilter = true;
                    isPrime = false;
                }
                for (int j = 3; j < i / 2 && !preFilter; j += 2)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result += i;
                }
                isPrime = true;
                preFilter = false;
            }
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 11
        private void button11_Click(object sender, EventArgs e)
        {
            string numbers = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08 " +
                            "49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00 " +
                            "81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65 " +
                            "52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91 " +
                            "22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80 " +
                            "24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50 " +
                            "32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70 " +
                            "67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21 " +
                            "24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72 " +
                            "21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95 " +
                            "78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92 " +
                            "16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57 " +
                            "86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58 " +
                            "19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40 " +
                            "04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66 " +
                            "88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69 " +
                            "04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36 " +
                            "20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16 " +
                            "20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54 " +
                            "01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";

            string numberString = "";
            int number = 0;
            int counter = 0;
            long product = 1;
            long result = 0;

            List<int> numbersList = new List<int>();
            var array = new int[20, 20];

            for (int i = 0; i < numbers.Length; i+=3)
            {
                for (int p = i; p <= i + 2 && p < numbers.Length; p++)
                {
                    if (char.IsDigit(numbers[p]))
                    {
                        numberString += numbers[p];
                    }
                    number = Convert.ToInt32(numberString);
                }
                numbersList.Add(number);
                numberString = "";
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array[i, j] = numbersList[counter];
                    
                    counter++;
                }
            }

            counter = 0;

            //Horizontal
            for (int i = 0; i <= 19; i++)
            {
                for (int j = 0; j <= 19; j++)
                {
                    product *= array[i, j];
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result) 
                        {
                            result = product; 
                        } 

                        counter = 0;
                        product = 1;
                        
                        if (j != 19) j -= 3;
                    }
                }
            }

            //Vertical
            for (int i = 0; i <= 19; i++)
            {
                for (int j = 0; j <= 19; j++)
                {
                    product *= array[j, i];
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result)
                        {
                            result = product;
                        }

                        counter = 0;
                        product = 1;

                        if (j != 19) j -= 3;
                    }
                }
            }

            //Diagonal
            int c = 0;
            int r = 0;
            for (int i = 0; i <= array.GetLength(1) - 4; i++)
            {
                c = i;
                counter = 0;
                r = 0;
                while (r <= array.GetLength(1) - 1 - i)
                {
                    product *= array[r, c];
                    c++;
                    r++;
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result)
                        {
                            result = product;
                        }

                        counter = 0;
                        product = 1;

                        if (c <= 19)
                        {
                            c -= 3;
                            r -= 3;
                        }
                    }
                }
            }

            for (int i = 1; i <= array.GetLength(1) - 4; i++)
            {
                r = i;
                counter = 0;
                c = 0;
                while (c <= array.GetLength(1) - 1 - i)
                {
                    product *= array[r, c];
                    c++;
                    r++;
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result)
                        {
                            result = product;
                        }

                        counter = 0;
                        product = 1;

                        if (r <= 19)
                        {
                            c -= 3;
                            r -= 3;
                        }
                    }
                }
            }

            for (int i = 19; i >= 3; i--)
            {
                c = i;
                counter = 0;
                r = 0;
                while (c >= 0)
                {
                    product *= array[r, c];
                    c--;
                    r++;
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result)
                        {
                            result = product;
                        }

                        counter = 0;
                        product = 1;

                        if (c >= 0)
                        {
                            c += 3;
                            r -= 3;
                        }
                    }
                }
            }

            for (int i = 1; i <= 16; i++)
            {
                r = i;
                counter = 0;
                c = 19;
                while (r <= 19)
                {
                    product *= array[r, c];
                    c--;
                    r++;
                    counter++;
                    if (counter == 4)
                    {
                        if (product > result)
                        {
                            result = product;
                        }

                        counter = 0;
                        product = 1;

                        if (r <= 19)
                        {
                            c += 3;
                            r -= 3;
                        }
                    }
                }
            }
            MessageBox.Show("" + result);
        }
    }
}
