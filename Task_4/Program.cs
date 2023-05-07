using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

    public static class ExtensionClass
    {

        public static void ExtensionMethod(this int[] value)
        {

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i + 1; j < value.Length; j++)
                {
                    if (value[i] > value[j])
                    {
                        int temp = value[i];
                        value[i] = value[j];
                        value[j] = temp;
                    }
                }
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            int[] value = new int[] { 4, 2, 6, 7, 1, 8, 9, 3, 5,12,67};

            Console.WriteLine(new String('=', 50));
            Console.WriteLine("До сортування:");
            foreach (var item in value)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new String('=',50));

            Console.WriteLine("Після сортування:");

            value.ExtensionMethod();

            foreach (var item in value)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new String('=', 50));

            Console.ReadKey();
        }
    }
}
