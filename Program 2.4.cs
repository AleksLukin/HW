using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
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

            bool a = int.TryParse(monTitle, out int result);
            if (result<4)
                if(middleTemp>0)
                Console.WriteLine("Дождливая зима");
            
            
        }
    }
}

/*1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести
среднесуточную температуру.
2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
3. Определить, является ли введённое пользователем число чётным.
4. (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести
сообщение «Дождливая зима».*/