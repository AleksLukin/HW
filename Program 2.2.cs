using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца - oт 0 до 11 "); // пользователь вводит номер месяца - oт 0 до 11
            string numMonth = Console.ReadLine(); // номер выводим на экран
            int numOfMonth = int.Parse(numMonth); // "парсим")))
            string monTitle = ""; // вводим строковую переменную обозначающую месяц
            switch (numOfMonth) // вводим оператор 
            {
                case 0:
                    monTitle = "January";
                    break; //break - прерывает выполнение программы
                case 1:
                    monTitle = "February";
                    break;
                case 2:
                    monTitle = "March";
                    break;
                case 3:
                    monTitle = "April";
                    break;
                case 4:
                    monTitle = "May";
                    break;
                case 5:
                    monTitle = "Juny";
                    break;
                case 6:
                    monTitle = "July";
                    break;
                case 7:
                    monTitle = "August";
                    break;
                case 8:
                    monTitle = "September";
                    break;
                case 9:
                    monTitle = "October";
                    break;
                case 10:
                    monTitle = "November";
                    break;
                case 11:
                    monTitle = "December";
                    break;
            }
            Console.WriteLine(monTitle);
        }
    }
}
