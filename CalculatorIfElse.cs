using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор");
            double oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            double total;
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Сумма " + a + " и " + b + " равна " + total);
            }
            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total);
            }
            else if (oper == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("на 0 делить нельзя");
                }
                else {
                    total = a / b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total);
                }

            }
            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " и " + b + " равно " + total);
            }
        }
    }
}
