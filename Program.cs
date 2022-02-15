using System;

namespace lab1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double b = (a - 4 + 1) * 3 / 2;
            Console.WriteLine($"Число {a} после математических преобразований ({a}-4+1)*3/2={b} ");

            int[] array = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0,100);
            Console.WriteLine("Элементы массива :");
            for (int y = 0; y < array.Length; y++)
            {
                Console.WriteLine(array[y]);
            }

        }

    }
}
