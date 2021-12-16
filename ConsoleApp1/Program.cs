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
            Random rand = new Random();
            //создаем и сортируем массив А
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-100, 100);
            }
            Array.Sort(a);
            Console.WriteLine("Массив A:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            //создаем и сортируем массив B
            for (int i = 0; i < n; i++)
            {
                b[i] = rand.Next(-100, 100);
            }
            Array.Sort(b);
            Console.WriteLine("Массив B:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();

            //метод слияния
            //пока не достигнем конца одного из массивов, выбираем меньший из элементов и добавляем в итоговый массив
            double[] A = new double[2*n];
            int l = 0, m = 0, k = 0;
            while (l < n && m < n)
            {
                if (a[l] <= b[m])
                {
                    A[k] = a[l];
                    l++;
                }
                else
                {
                    A[k] = b[m];
                    m++;
                }
                k++;
            }
            //когда один из массивов заканчивается, записываем в итоговый массив оставшиеся элементы
            while (l < n)
            {
                A[k] = a[l];
                l++;
                k++;
            }
             while (m < n)
             {
                A[k] = b[m];
                m++;
                k++;
             }
           
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
