using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Написать программу, которая будет подсчитывать количество четных и нечетных целых чисел в диапазоне указанном пользователем
namespace Numberofevenandoddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число диапазона");
            int from = Convert.ToInt32(Console.ReadLine()); // от какого числа
            Console.WriteLine("Введите последнее число диапазона");
            int to = Convert.ToInt32(Console.ReadLine()); // до какого числа
            int even = 0; // четные
            int odd = 0; // нечетные
            int evenSum = 0; // сумма четных
            int oddSum = 0; // сумма нечетных
            while (from <= to)
            {
                if (from % 2 == 0)
                {
                    evenSum += from;
                    even++;
                }
                else
                {
                    oddSum = oddSum + from; 
                    odd++;
                }
                from++;

            }
            Console.WriteLine("количество четных чисел: " + even + ", " + "количество нечетных чисел: " + odd);
            Console.WriteLine("сумма четных чисел: " + evenSum + ", " + "сумма нечетных чисел: " + oddSum);
        }
    }
}
