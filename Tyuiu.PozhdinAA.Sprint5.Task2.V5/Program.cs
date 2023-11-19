using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PozhdinAA.Sprint5.Task2.V5.Lib;

namespace Tyuiu.PozhdinAA.Sprint5.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Пождин А. А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный с      *");
            Console.WriteLine("* клавиатуры. Заменить нечетные элементы массива на 0. Результат          *");
            Console.WriteLine("* сохранить в файл OutPutFileTask2.csv и вывести на консоль               *");
            Console.WriteLine("* 9; 6; 6                                                                 *");
            Console.WriteLine("* 8; 7; 2                                                                 *");
            Console.WriteLine("* 1; 7; 8                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { { 9, 6, 6 },
                                            { 8, 7, 2 },
                                            { 1, 7, 8 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");

            using (StreamReader reader = new StreamReader(res))
            {
                string mtrx = reader.ReadToEnd();
                Console.WriteLine(mtrx);
            }
            Console.ReadKey();
        }
    }
}