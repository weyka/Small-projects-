using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор");
                char oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                double total;
                switch (oper)
                {
                    case ('+'):
                        total = a + b;
                        Console.WriteLine("Сумма " + a + " и " + b + " равна " + total);
                        break;
                    case ('-'):
                        total = a - b;
                        Console.WriteLine("Разность " + a + " и " + b + " равна " + total);
                        break;
                    case ('/'):
                        total = a / b;
                        if (b == 0)
                        {
                            Console.WriteLine("На 0 делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine("Деление " + a + " и " + b + " равно " + total);
                        }
                        break;
                    case ('*'):
                        total = a * b;
                        Console.WriteLine("Умножение " + a + " и " + b + " равно " + total);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
