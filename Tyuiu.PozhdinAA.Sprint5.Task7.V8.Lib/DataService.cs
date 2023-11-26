using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PozhdinAA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {

            string str = @"C:\DataSprint5\OutPutFileTask7V8.txt";

            FileInfo fileInfo = new FileInfo(str);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(str);
            }
            string strl = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace('А', 'а').Replace('Б', 'б').Replace('В', 'в').Replace('Г', 'г').Replace('Д', 'д').Replace('Е', 'е').Replace('Ё', 'ё').Replace('Ж', 'ж').Replace('З', 'з').Replace('И', 'и').Replace('Й', 'й').Replace('К', 'к').Replace('Л', 'л').Replace('М', 'м').Replace('Н', 'н').Replace('О', 'о').Replace('П', 'п').Replace('Р', 'р').Replace('С', 'с').Replace('Т', 'т').Replace('У', 'у').Replace('Ф', 'ф').Replace('Х', 'х').Replace('Ц', 'ц').Replace('Ч', 'ч').Replace('Ш', 'ш').Replace('Щ', 'щ').Replace('Ъ', 'ъ').Replace('Ы', 'ы').Replace('Ь', 'ь').Replace('Э', 'э').Replace('Ю', 'ю').Replace('Я', 'я');
                    strl = line;
                }
                    File.AppendAllText(str, strl + Environment.NewLine);
                    strl = "";
                }
            return str;
        }
    }
}