using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели (1-7): ");
            int dayNumber = int.Parse(Console.ReadLine());
            // Вызов вспомогательного метода и вывод результата
            Console.WriteLine($"День недели: {GetDayOfWeek(dayNumber)}");
            Console.ReadKey();
        }
        static string GetDayOfWeek(int dayNumber)
        {
            // Массив с днями недели
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            // Проверка на корректность номера дня
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                return days[dayNumber - 1]; // Индексация массива с 0, поэтому вычитаем 1
            }
            else
            {
                return "Некорректный номер дня";
            }
        }
    }
}

