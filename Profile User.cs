using System;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your surname:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            double height = double.Parse(Console.ReadLine());
            double imt = weight / (height * height);
            string profile =
                  $"Your profile:{Environment.NewLine}"
                + $"Full name {Surname}, {Name}{Environment.NewLine}"
                + $"Age {age}{Environment.NewLine}"
                + $"Weight {weight}{Environment.NewLine}"
                + $"Height {height}{Environment.NewLine}"
                + $"Body Mass Index (IMT): {imt}";
            Console.WriteLine(profile);
        }
    }
}