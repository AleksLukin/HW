using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число "); // пользователь вводит число
            string num = Console.ReadLine(); // число выводим на экран
            double num1 = double.Parse(num); // "парсим")))
            double num2 = num1 % 2; //выделяем остаток при делении

            if (num2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
                Console.WriteLine("нечетное число");
        }
    }
}
