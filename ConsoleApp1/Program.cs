using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double[] a = new double[n];
            double[] b = new double[n];
            Console.WriteLine("Введите массив A");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine()); // считываем элемент
            }
            Console.WriteLine("Введите массив B");
            for (int i = 0; i < n; i++)
            {
                b[i] = Convert.ToDouble(Console.ReadLine()); // считываем элемент
            }

            double[] A = new double[n * 2];
            int l = 0, j = 0, k = 0;
            while (l < n && j < n)
            {
                if (a[l] <= b[j])
                {
                    A[k] = a[l];
                    l++;
                }
                else
                {
                    A[k] = b[j];
                    j++;
                }
                k++;
            }


            Console.WriteLine("Вывод A: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
