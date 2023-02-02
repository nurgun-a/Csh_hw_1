using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Csh_hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.Yellow;
            ForegroundColor = ConsoleColor.DarkBlue;
            SetWindowSize(40, 15);
            SetBufferSize(40, 15);
            do
            {
                Clear();
                int res;
                Title = "Калькулятор";
               // WriteLine("Калькулятор\n");
                Write("Введите число: ");
                int num1 = Convert.ToInt32(ReadLine());
                Write("Введите символ(/,+,-,*): ");
                string symbol = ReadLine();
                Write("Введите число: ");
                int num2 = Convert.ToInt32(ReadLine());
                
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        WriteLine(num1+" + "+num2+ " = " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        WriteLine(num1 + " - " + num2 + " = " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        WriteLine(num1 + " * " + num2 + " = " + res);
                        break;
                    case "/":
                        double res_1= (double)((num1 * 1.0) / (num2 * 1.0));
                        WriteLine(num1 + " / " + num2 + " = " + res_1);
                        break;
                    default:
                        WriteLine("Ошибка ввода!!!");
                        break;
                }
                WriteLine();
                WriteLine("Нажмите \"Enter\", для продолжения");
                ReadLine();
                
            }
            while (true);
        }
    }
}
