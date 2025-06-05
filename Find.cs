using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46x
{
    static class Find
    {
        public static void Magazines(List<Magazine> magazines)
        {
            List<Magazine> findedMagazines = magazines;

            Console.WriteLine("Выберите критерий сравнения:\n" +
                "1. Название\n" +
                "2. Периодичность выхода\n" +
                "3. Дата выхода\n" +
                "4. Тираж\n");

            int choice = Console.ReadKey(true).KeyChar - '0';

            bool isTrueKey = true;
            do
            {
                switch (choice)
                {
                    case 1: findedMagazines = MagazinesByName(magazines); break;
                    case 2: findedMagazines = MagazinesByOutputFrequency(magazines); break;
                    case 3: findedMagazines = MagazinesByReleaseDate(magazines); break;
                    case 4: findedMagazines = MagazinesByCirculation(magazines); break;
                    default: isTrueKey = false; break;
                }
            } while (!isTrueKey);

            Console.WriteLine();
            Magazine.Output(findedMagazines);
        }

        static List<Magazine> MagazinesByName(List<Magazine> magazines)
        {
            Console.Write("Введите название журнала: ");
            string name = Console.ReadLine();

            return magazines.Where(m => m.Name == name).ToList();
        }

        static List<Magazine> MagazinesByOutputFrequency(List<Magazine> magazines)
        {
            Console.Write("Введите нужную периодичность выхода: ");
            Frequency frequency;
            while (!Enum.TryParse(Console.ReadLine(), out frequency))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неправильный ввод! ");
                Console.ResetColor();

                Console.WriteLine($"Ввести можно одно из следующих значений: " +
                    $"{string.Join(", ", Enum.GetNames(typeof(Frequency)))}");

                Console.Write("Введите нужную периодичность выхода: ");
            }

            return magazines.Where(m => m.OutputFrequency == frequency).ToList();
        }

        static List<Magazine> MagazinesByReleaseDate(List<Magazine> magazines)
        {
            Console.WriteLine("Введите выражение в формате \"{оператор сравнения} {дата выпуска}\"\n" +
                "Возможные операторы сравнения: >, <, >=, <=, =");

            Func<Magazine, bool> func = ((m) => true);
            while (true)
            {
                Console.Write("Выражение: ");
                string[] expression = Console.ReadLine().Split(' ');

                if (expression.Length != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильная форма выражения!");
                    Console.ResetColor();
                    continue;
                }

                DateTime date;
                if (!DateTime.TryParse(expression[1], out date))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Дата неправильно введена!");
                    Console.ResetColor();
                    continue;
                }

                bool isOperatorExist = true;
                switch (expression[0])
                {
                    case ">": func = ((m) => m.ReleaseDate > date); break;
                    case "<": func = ((m) => m.ReleaseDate < date); break;
                    case ">=": func = ((m) => m.ReleaseDate >= date); break;
                    case "<=": func = ((m) => m.ReleaseDate <= date); break;
                    case "=": func = ((m) => m.ReleaseDate == date); break;
                    default: isOperatorExist = false; break;
                }
                if (!isOperatorExist)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Оператор неправильно введен!");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            return magazines.Where(func).ToList();
        }

        static List<Magazine> MagazinesByCirculation(List<Magazine> magazines)
        {
            Console.WriteLine("Введите выражение в формате \"{оператор сравнения} {тираж}\"\n" +
                "Возможные операторы сравнения: >, <, >=, <=, =");

            Func<Magazine, bool> func = ((m) => true);
            while (true)
            {
                Console.Write("Выражение: ");
                string[] expression = Console.ReadLine().Split(' ');

                if(expression.Length != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильная форма выражения!");
                    Console.ResetColor();
                    continue;
                }

                int circulation;
                if (!int.TryParse(expression[1], out circulation))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Значение тиража неправильно введено!");
                    Console.ResetColor();
                    continue;
                }

                bool isExistanceOperator = true;
                switch (expression[0])
                {
                    case ">": func = ((m) => m.Circulation > circulation); break;
                    case "<": func = ((m) => m.Circulation < circulation); break;
                    case ">=": func = ((m) => m.Circulation >= circulation); break;
                    case "<=": func = ((m) => m.Circulation <= circulation); break;
                    case "=": func = ((m) => m.Circulation == circulation); break;
                    default: isExistanceOperator = false; break;
                }
                if (!isExistanceOperator)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Оператор неправильно введен!");
                    Console.ResetColor();
                    continue;
                }
                break;
            }

            return magazines.Where(func).ToList();
        }
    }
}
