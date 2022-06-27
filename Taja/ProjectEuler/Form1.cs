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
            int result3 = 0;
            int result5 = 0;
            int total = 0;
            for (int i = 1; result3 < 1000; i++)
            {
                result3 = i * 3;
                result5 = i * 5;
                if (result3 < 1000 && result3 % 5 != 0)
                {
                    total += result3;
                }
                if (result5 < 1000)
                { 
                    total += result5;
                }
            }
            MessageBox.Show(total.ToString());
        }

        //Ejercicio 2
        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = 1;
            int number2 = 2;
            int temp = 0;
            int result = 0;
            while (true)
            {
                if (number1 < 4000000 && number1 % 2 == 0)
                {
                    result += number1;
                }
                if (number2 < 4000000 && number2 % 2 == 0)
                {
                    result += number2;
                }
                temp = number1 + number2;
                number1 = temp;
                temp = number1 + number2;
                number2 = temp;

                if (number1 >= 4000000 && number2 >= 4000000)
                {
                    break;
                }
            }
            MessageBox.Show(result.ToString());
        }

        //Ejercicio 3
        private void button3_Click(object sender, EventArgs e)
        {
            int primeFactor = 0;
            bool isPrime = true;
            long result = 1;

            for (int i = 2; true; i++)
            {
                if (600851475143 % i  == 0 )
                {
                    //for (int j = 2; j < i && isPrime; j++)
                    //{
                    //    if (i % j == 0)
                    //    {
                    //        isPrime = false;
                    //    }
                    //}
                    //if (isPrime)
                    //{
                        result *= i;
                        if (result == 600851475143)
                        {
                            primeFactor = i;
                            MessageBox.Show(primeFactor.ToString());
                            break;
                        }
                    //}
                }
            }
        }

        //Ejercicio 4
        private void button4_Click(object sender, EventArgs e)
        {
            int palindromicNumber = 0;
            int product = 0;
            int product2 = 0;
            int number = 0;
            int finalNumber = 0;
            string numberString = "";
            bool stop;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = i; j < 1000; j++)
                {
                    numberString = "";
                    stop = false;
                    product = i * j;
                    product2 = product;

                    while (!stop)
                    {
                        if (product2 != 0 && product2 >= 1)
                        {
                            number = product2 % 10;
                            product2 = product2 / 10;
                            if (number >= 1 || number == 0)
                            {
                                numberString += "" + number;
                            }
                        }
                        else stop = true;
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
            bool isPrime = true;
            int primeCounter = 0;
            for (int i = 2; true; i++)
            {
                isPrime = true;
                for (int j = 2; j < i && isPrime; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    primeCounter++;
                }
                if (primeCounter == 10001)
                {
                    MessageBox.Show(i.ToString());
                    break;
                }
            }
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

            for (int i = 0; true; i++)
            {
                for (int j = 0; j <= 12 && product != 0; j++)
                {
                    index = i + j;
                    if (index <= 999)
                    {
                        product *= (int)Char.GetNumericValue((char)numbersString[index]);
                    }
                    else goto stop;
                }
                if (product != 0 && product > result)
                {
                    result = product;
                }
                product = 1;
            }
            stop:
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

            int bTemp;

            int p = 1;
            int q = 1;

            long result;
            while (true)
            {
                q = 1;
                p++;
                a = p * p - q * q;
                b = 2 * (p * q);
                c = p * p + q * q;
                if (a > b)
                {
                    bTemp = a;
                    a = b;
                    b = bTemp;
                }
                if (a + b + c == 1000) break;
                else while (q + 1 < p)
                    {
                        q++;
                        a = p * p - q * q;
                        b = 2 * p * q;
                        c = p * p + q * q;
                        if (a > b)
                        {
                            bTemp = a;
                            a = b;
                            b = bTemp;
                        }
                        if (a + b + c == 1000) break;
                    }
            }
            result = a * b * c; 
            MessageBox.Show(result.ToString());
        }
    }
}
