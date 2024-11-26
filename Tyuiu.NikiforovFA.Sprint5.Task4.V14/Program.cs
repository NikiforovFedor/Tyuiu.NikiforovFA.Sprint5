
using Tyuiu.NikiforovFA.Sprint5.Task4.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая считает результат по       *");
            Console.WriteLine("* формуле, беря исходныет данные из файла                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: C:\\DataSprint5\\InPutDataFileTask4V14.txt             *");
            string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
            Console.WriteLine("* Результат:                                                              *");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
