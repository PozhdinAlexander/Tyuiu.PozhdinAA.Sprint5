using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task1.V5.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Пождин А. А. | АСОиУБ-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                  *");
            Console.WriteLine("* Задания #1                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                         *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и               *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");



            Console.ReadKey();
        }
    }
}