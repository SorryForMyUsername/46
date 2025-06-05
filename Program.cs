using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_4
{
    internal class Program
    {
        enum UserRole { Администратор, Модератор, Пользователь, Гость }

        static void Main(string[] args)
        {
            Console.Write("Введите вашу роль: ");
            UserRole role;

            if (Enum.TryParse(Console.ReadLine(), out role))
            {
                Console.WriteLine($"Вы зарегестрированы как {role.ToString().ToLower()}");
            }
            else
            {
                Console.WriteLine("Такой роли не существует!");
            }
        }
    }
}
