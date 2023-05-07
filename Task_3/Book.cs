using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Book
    {

        private List<string> books = new List<string>()
        {
            "Метро быстро доставляет меня на работу каждое утро.",
            "Я предпочитаю ездить на велосипеде, чтобы избежать пробок.",
            "Автобусы сейчас ездят с большими интервалами, нужно быть внимательнее к расписанию.",
            "Комфортабельные поезда делают поездки на дальние расстояния приятными.",
            "Мне всегда нравилось ездить на мотоцикле, это очень увлекательно.",
            "Электрические самокаты очень удобны для перемещений в городе.",
            "Такси - отличный выбор для тех, кто не хочет ездить на своей машине.",
            "Легковой автомобиль - идеальный вариант для поездок с семьей.",
            "Я всегда предпочитаю использовать общественный транспорт, это экологично и дешево.",
            "Грузовые автомобили необходимы для перевозки товаров на дальние расстояния.",
        };

        public void FindNext(string str)
        {
            bool poisk = FindAndReplaceManager.FindNext(str, books);

            if (poisk)
            {
                int index = books.IndexOf(str);
                Console.WriteLine("\nТАка строка е в книзі!");
                Console.WriteLine($"Сторінка {index}: ");
                Console.WriteLine(new String('-', 50));
                Console.WriteLine(books[index]);
                Console.WriteLine(new String('-', 50));
            }
            else
            {
                Console.WriteLine(new String('-', 50));
                Console.WriteLine("Такої строки нема!");
                Console.WriteLine(new String('-', 50));
            }

        }

        public class Notes
        {
            private List<string> notes = new List<string>();



            public void AddNewNotes(string textNot)
            {
                notes.Add(textNot);
            }

            public void ShowAllNotes()
            {

                if (notes.Count != 0)
                {
                    int index = 1;
                    foreach (var item in notes)
                    {
                        Console.WriteLine(new String('-', 50));
                        Console.WriteLine($"{index}) {item}");
                        Console.WriteLine(new String('-', 50));
                        index++;
                    }
                }
                else
                {
                    Console.WriteLine(new String('-', 50));
                    Console.WriteLine("Немае Нотаток!");
                    Console.WriteLine(new String('-', 50));
                }

            }

        }

    }
}
