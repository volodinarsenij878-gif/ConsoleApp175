using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Ошибка."); return; }
            Console.Write("Второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Ошибка."); return; }

            double max = a > b ? a : b;
            double min = a < b ? a : b;

            if (min == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
                return;
            }

            double result = max / min;
            Console.WriteLine($"Частное большего на меньшее: {result}");
        }
    }
}