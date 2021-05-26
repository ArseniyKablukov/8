using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = random.Next(-50, 50);
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine("\n\n");
            }

            Console.WriteLine("\n");
            //Сравнение чисел по диагонали
            int d = 0;
            int dd = 1;
            int f = -51;
            int ii = 0;
            int jj = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {

                for (int j = d; j < dd; j++)
                {
                    if (m[i, j] > f)
                    {
                        f = m[i, j];
                        ii = i;
                        jj = j;
                    }
                }
                d++;
                dd++;
            }
            Console.WriteLine($"Координаты [X={jj + 1} Y={10 - (ii + 1)}]\nНаибольшее число главной диагонали {f}\n");


            d = 0;
            dd = 1;
            f = -51;
            ii = 0;
            jj = 0;
            for (int i = m.GetLength(0) - 1; i > 0; i--)
            {

                for (int j = d; j < dd; j++)
                {
                    if (m[i, j] > f)
                    {
                        f = m[i, j];
                        ii = i;
                        jj = j;
                    }
                }
                d++;
                dd++;
            }
            Console.WriteLine($"Координаты [X={jj + 1} Y={10 - (ii + 1)}]\nНаибольшее число побочной диагонали {f}\n");


            //Сумма элементов столбца
            Console.WriteLine("Суммы элементов столбцов");
            int sum = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {

                for (int j = 0; j < m.GetLength(0); j++)
                {
                    sum += m[j, i];

                }
                Console.Write(sum + "\t");
                sum = 0;
            }
        }
    }
}
