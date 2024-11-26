using Tyuiu.NikiforovFA.Sprint5.Task6.V18.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текствовых файлов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая находит количество одно-   *");
            Console.WriteLine("* разрядных чисел в файле                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: C:\\DataSprint5\\InPutDataFileTask6V18.txt              *");
            string path = @"C:\DataSprint5\InPutDataFileTask6V18.txt";
            Console.WriteLine("* Результат:                                                              *");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}