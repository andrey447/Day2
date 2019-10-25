using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------
            Console.WriteLine("********** ЗАДАНИЕ 1 ***********");
            Console.WriteLine();
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double maxA = -1000000000, minA = 1000000000;
            double maxB = -1000000000, minB = 1000000000;
            double max, min;
            double sum = 0, multip = 1;
            double sumChet = 0, sumNechet = 0;
            Random rnd = new Random();

            Console.WriteLine("Введите элементы массива:");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}-й элемент массива:", i);
                A[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    B[i, j] = rnd.Next(100);

            foreach (double i in A)
            {
                Console.Write("{0}\t", i);
                if (i > maxA)
                    maxA = i;
                if (i < minA)
                    minA = i;
                sum += i;
                multip *= i;
                if (i % 2 == 0)
                    sumChet += i;
            }
                
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", B[i, j]);
                    if (B[i, j] > maxB)
                        maxB = B[i, j];
                    if (B[i,j] < minB)
                        minB = B[i, j];
                    sum += B[i, j];
                    multip *= B[i, j];
                    if (i == 0 && j % 2 != 0)
                        sumNechet++;
                }  
                Console.WriteLine();
            }

            if (maxA >= maxB)
                max = maxA;
            else max = maxB;

            if (minA <= minB)
                min = minA;
            else min = minB;

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массивов равен {0}", max);
            Console.WriteLine("Минимальный элемент массивов равен {0}", min);
            Console.WriteLine("Сумма элементов массивов равна {0}", sum);
            Console.WriteLine("Произведение элементов массивов равна {0}", multip);
            Console.WriteLine("Сумма четных элементов массива А равна {0}", sumChet);
            Console.WriteLine("Сумма нечетных столбцов массива B равна {0}", sumNechet);


            //-----------------------------------------------------------------------------------------
            Console.WriteLine("********** ЗАДАНИЕ 2 ***********");
            Console.WriteLine();
            int[] M = { 12, 45, 57, 11, 90 };
            int[,] N =
            {
                {5,15,32,74,32 },
                {35,63,90,44,12 },
                {87,37,87,23,4 },
                {56,70,90,17,49 }
            };
            
            int[] R = new int[25];
            int lengthM = M.Length;
            int lengthN= N.Length;

            for (int i=0; i<M.Length; i++)
                R[i] = M[i];

            int k = M.Length;
            for (int i=0; i<4;i++)
                for (int j=0;j<5;j++)
                {
                    R[k - 1] = N[i, j];
                    k++;
                }

            Array.Sort(R);

            foreach (int i in R)
                Console.Write("{0}\t", i);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив без повторений:");

            for (int i = 1; i < (R.Length - 1); i++)
                if (R[i] == R[i - 1])
                    for (int j = i + 1; j < R.Length; j++)
                    {
                        R[j - 1] = R[j];
                        R[j] = 0;
                    }

            foreach (int i in R)
                Console.Write("{0}\t", i);
            Console.WriteLine();
            Console.WriteLine();


            //-----------------------------------------------------------------------------------------
            Console.WriteLine("********** ЗАДАНИЕ 3 ***********");
            Console.WriteLine();

            string str;
            int len;
            bool flag = true;

            Console.WriteLine("Введите строку");
            str = Console.ReadLine();

            if (str.Length % 2 == 0)
                len = str.Length / 2;
            else len = str.Length / 2 + 1;

            for (int i = 0; i < len; i++)
            {
                if (str[i] != str[str.Length-1-i])
                {
                    Console.WriteLine("Не палиндром.");
                    flag = false;
                    break;
                } 
            }

            if (flag == true)
                Console.WriteLine("Палиндром!");
            Console.WriteLine();

            
            //-----------------------------------------------------------------------------------------
            Console.WriteLine("********** ЗАДАНИЕ 4 ***********");
            Console.WriteLine();

            Console.WriteLine("Введите предложение:");
            string st = Console.ReadLine();
            int world = 0;

            int indexOfSpace = st.IndexOf(' ');
            
            if (indexOfSpace != 0)
                world++;

            Console.WriteLine("Слов в предложении {0}", world);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
