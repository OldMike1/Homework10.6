using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10._6
{
    class Program
    {
        static int Max(int[] array)
        {
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x < array[i])
                    x = array[i];

            }
            return x;
        }

        static int Min(int[] array)
        {
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (x > array[i])
                    x = array[i];

            }
            return x;
        }

        static void Main(string[] args)
        {
            int x =int.Parse(Console.ReadLine());
            int[] array = new int[x];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int max = Max(array);
            int min = Min(array);
            Console.WriteLine("Max = " +max);
            Console.WriteLine("Min = "+min);
        }
    }
}
