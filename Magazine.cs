using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46x
{
    class Magazine
    {
        public string Name { get; set; }
        public Frequency OutputFrequency { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Circulation { get; set; }

        public Magazine() { }

        public Magazine(string name, Frequency outputFrequency, DateTime releaseDate, int circulation)
        {
            Name = name;
            OutputFrequency = outputFrequency;
            ReleaseDate = releaseDate;
            Circulation = circulation;
        }

        public static Magazine Input()
        {
            Console.Write("---| Создание журнала |---\n" +
                          "Название журнала: ");
            string name = Console.ReadLine();

            Console.Write("Периодичность выхода: ");
            Frequency frequency;
            while (!Enum.TryParse(Console.ReadLine(), out frequency))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неправильный ввод! ");
                Console.ResetColor();

                Console.WriteLine($"Ввести можно одно из следующих значений: " +
                    $"{string.Join(", ", Enum.GetNames(typeof(Frequency)))}");

                Console.Write("Периодичность выхода: ");
            }

            Console.Write("Дата выпуска: ");
            DateTime releaseDate;
            while(!DateTime.TryParse(Console.ReadLine(), out releaseDate))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неправильный ввод! ");
                Console.ResetColor();

                Console.Write("Формат даты: дд.мм.гггг\n" +
                              "Дата выпуска: ");
            }

            Console.Write("Тираж: ");
            int circulation;
            while (!int.TryParse(Console.ReadLine(), out circulation) && circulation <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неправильный ввод! ");
                Console.ResetColor();

                Console.Write("Значение тиража дожно быть положительным целым числом.\n" +
                              "Тираж: ");
            }

            Console.WriteLine("---| Журнал создан |---");
            return new Magazine(name, frequency, releaseDate, circulation);
        }

        public static void Output(List<Magazine> magazines)
        {
            if(magazines.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Журналы отсутствуют!");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Название",-20} | {"Периодичность выхода",-20} | {"Дата выхода",-11} | {"Тираж",-5}");
            Console.ResetColor();

            foreach (Magazine magazine in magazines)
            {
                Console.WriteLine($"{magazine.Name,-20} | {magazine.OutputFrequency,-20} | {magazine.ReleaseDate,11:dd.MM.yyyy} | {magazine.Circulation,5}");
            }
        }
    }
}
