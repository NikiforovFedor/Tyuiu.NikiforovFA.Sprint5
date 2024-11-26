using Tyuiu.NikiforovFA.Sprint5.Task5.V8.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая находит минимальное число в*");
            Console.WriteLine("* файле, беря исходные данные из него же                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: C:\\DataSprint5\\InPutDataFileTask5V8.txt              *");
            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
            Console.WriteLine("* Результат:                                                              *");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
