using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task7.V8.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V8.txt";
            Console.Title = "Спринт #5 | Выполнил: Пождин А. А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание: 7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все заглавные русские буквы на строчные.                       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V8.txt         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine($"Данные находятся в файле: {path}");
            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("**");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Полученные данные находятся в файле:");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}