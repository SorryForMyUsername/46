using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите должность сотрудника:");
            Post post = (Post)Enum.Parse(typeof(Post), Console.ReadLine());
            Console.WriteLine("Введите количество отработанных часов:");
            int hours = int.Parse(Console.ReadLine());

            Accauntant accauntant = new Accauntant();

            if (accauntant.AskForBonus(post, hours))
            {
                Console.WriteLine("Сотруднику положена премия.");
            }
            else
            {
                Console.WriteLine("Сотруднику не положена премия.");
            }

            Console.ReadKey(true);
        }
    }
}
