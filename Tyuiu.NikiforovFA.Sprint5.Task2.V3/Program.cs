using Tyuiu.NikiforovFA.Sprint5.Task2.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая заменяет нечетные элементы *");
            Console.WriteLine("* матрицы на ноль и записывает результат в файл                           *");
            Console.WriteLine("***************************************************************************");

            int[,] input = { { 5, 9, 1 }, { 1, 3, 9 }, { 1, 2, 2 } };
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.SaveToFileTextData(input));
        }
    }
}
