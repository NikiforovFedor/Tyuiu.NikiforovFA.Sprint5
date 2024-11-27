using Tyuiu.NikiforovFA.Sprint5.Task7.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая удаляет все одно-          *");
            Console.WriteLine("* разрядные чисела в файле                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные: C:\\DataSprint5\\InPutDataFileTask7V29.txt             *");
            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";
            Console.WriteLine("* Результат:                                                              *");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
        }
    }
}
