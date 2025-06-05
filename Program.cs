using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:\n" +
                    "1. Сумма\n" +
                    "2. Вычитание\n" +
                    "3. Умножение\n" +
                    "4. Деление\n" +
                    "*. Выход\n");

                MathOps choice = (MathOps)Console.ReadKey(true).KeyChar - '0' - 1;

                switch (choice)
                {
                    case MathOps.Sum: Sum(); break;
                    case MathOps.Subtraction: Substraction(); break;
                    case MathOps.Multiplication: Multipication(); break;
                    case MathOps.Division: Divide(); break;
                    default: return;
                }
                Console.WriteLine();
            }
        }

        static void Sum()
        {
            Console.Write("Первое число: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine($"{first} + {second} = {first + second}");
        }

        static void Substraction()
        {
            Console.Write("Первое число: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine($"{first} - {second} = {first - second}");
        }

        static void Divide()
        {
            Console.Write("Первое число: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine($"{first} / {second} = {first / second}");
        }

        static void Multipication()
        {
            Console.Write("Первое число: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine($"{first} * {second} = {first * second}");
        }
    }
}
