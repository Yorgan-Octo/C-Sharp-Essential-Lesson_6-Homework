using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            Book.Notes notes = new Book.Notes();

            while (true)
            {

                Console.WriteLine(new String('-', 50));
                Console.WriteLine("1 - Пошук за строкою; | 2 - Нотатки");
                Console.WriteLine(new String('-', 50));

                Console.Write("Виберіть пункт меню: ");
                int namMenu = UserInterface.NamberMenuIn();

                switch (namMenu)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.Write("Введіть строку для пошуку: ");
                            string pisktext = Console.ReadLine();

                            book.FindNext(pisktext);


                            UserInterface.DelayMess();

                            break;
                        }
                    case 2:
                        {

                            while (true)
                            {
                                Console.Clear();

                                Console.WriteLine(new String('-', 50));
                                Console.WriteLine("1 - Всі нотатки; | 2 - Додати Нотатки | 3 - Попередне меню");
                                Console.WriteLine(new String('-', 50));

                                Console.Write("Виберіть пункт меню: ");
                                int namMenuNotes = UserInterface.NamberMenuIn();

                                if (namMenuNotes == 1)
                                {

                                    Console.Clear();

                                    notes.ShowAllNotes();

                                    UserInterface.DelayMess();
                                }
                                else if (namMenuNotes == 2)
                                {
                                    Console.Clear();
                                    Console.Write("Введіть текст нотатки: ");
                                    string textNotes = Console.ReadLine();

                                    notes.AddNewNotes(textNotes);

                                }
                                else if (namMenuNotes == 3)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    UserInterface.ErrorShow("Такого пункта меню немае Спробуйде ще раз!");
                                    UserInterface.DelayMess();
                                }

                            }

                            break;
                        }
                    default:
                        {
                            UserInterface.ErrorShow("Такого пункта меню немае Спробуйде ще раз!");
                            UserInterface.DelayMess();

                            break;
                        }
                }


            }

        }
    }
}
