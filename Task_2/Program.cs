using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            Console.Write("Введіть строку для пошуку: ");
            string pisktext = Console.ReadLine();

            book.FindNext(pisktext);

            Console.ReadKey();

        }
    }
}
