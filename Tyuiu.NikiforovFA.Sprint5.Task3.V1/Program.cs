using Tyuiu.NikiforovFA.Sprint5.Task3.V1.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task3.V1
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая считает результат по       *");
            Console.WriteLine("* формуле и записывает его в файл                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: x = 3                                                  *");
            int x = 3;
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.SaveToFileTextData(x));
        }
    }
}
