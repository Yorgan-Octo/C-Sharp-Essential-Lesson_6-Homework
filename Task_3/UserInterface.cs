using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class UserInterface
    {


        public static int NamberMenuIn()
        {

            int namMenu;
            while (true)
            {
                try
                {
                    Console.Write("Виберіть пункт меню: ");
                    namMenu = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    ErrorShow("Помилка повторіть спробу;");
                }
            }

            return namMenu;
        }

        public static void ErrorShow(string message = "Помилка")
        {
            ConsoleColor color = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }


        public static void DelayMess(string message = "\nНатисніть щоб продовжити")
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }


    }
}
