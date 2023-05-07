using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double operand1 = UserInterface.InNumData("Введіть число 1: ");

                double operand2 = UserInterface.InNumData("Введіть число 2: ");

                string mathOperator = UserInterface.InMathOperator();

                if (mathOperator == "/" && operand1 == 0 || operand2 == 0)
                {
                    UserInterface.ShowError("На нуль діліти не можна!");

                    Console.WriteLine("\nНатисни на будь яку кнопку щоб продовжити!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                double sum = default;
                sum = (mathOperator == "+") ? Calculator.Add(operand1, operand2) : 
                    (mathOperator == "-") ? Calculator.Sub(operand1, operand2) :
                    (mathOperator == "*") ? Calculator.Mul(operand1, operand2) : 
                    Calculator.Div(operand1, operand2);

                Console.Clear();
                Console.WriteLine(new String('=', 50));
                Console.WriteLine($"Результат операції: {operand1} {mathOperator} {operand2} буде {sum}");
                Console.WriteLine(new String('=', 50));

                Console.WriteLine("Натисни на будь яку кнопку щоб продовжити!");
                Console.WriteLine(new String('-', 50));
                Console.ReadKey();
                Console.Clear();
            }




        }
    }
}
