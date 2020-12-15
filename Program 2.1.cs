using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите минимальную температуру ");
            string minTemp = Console.ReadLine(); //пользователь вводит минимальную температуру
            Console.Write("Введите максимальную температуру ");
            string maxTemp = Console.ReadLine(); //пользователь вводит максимальную температуру
            int minTemp1 = int.Parse(minTemp);// выполняем конверсию из стринга в инт минимальной температуры
            int maxTemp2 = int.Parse(maxTemp); // выполняем конверсию из стринга в инт максимальной температуры 
            int middleTemp = (maxTemp2 + minTemp1) / 2;
            Console.WriteLine($"Среднесуточная температура равна {middleTemp}"); // выводим на консоль среднесуточную температуру
        }
    }
}
