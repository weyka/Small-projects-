using System;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p;
            double s;
            // вычислим периметр треугольника
            p = 0.5 * (a + b + c);
            // вычислим площадь треугольника по формуле Герона
            s = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine(s);   
        }
    }
}