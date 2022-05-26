using System;
using System.IO;
using System.Text;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2004\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2004\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fs.Close();

            //cчитывание года из файла
            int takeyear = Convert.ToInt32(File.ReadAllText(inputpath));

            //сравнение и запись 1 или 0
            if ((takeyear % 4 == 0) && (takeyear % 100 != 0) || (takeyear % 400 == 0))
            {
                File.WriteAllText(outputpath, 1.ToString());
            }
            else
            {
                File.WriteAllText(outputpath, 0.ToString());
            }


        }
    }
}
