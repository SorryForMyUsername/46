using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Magazine> magazines = new List<Magazine>();
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить журнал\n" +
                    "2. Вывести все журналы\n" +
                    "3. Поиск журналов\n" +
                    "4. Выход\n");

                int choice = Console.ReadKey(true).KeyChar - '0';

                switch (choice)
                {
                    case 1: magazines.Add(Magazine.Input()); break;
                    case 2:  break;
                    case 3: break;
                    case 4: return;
                }
                Console.WriteLine();
            }
        }
    }
}
