using Tyuiu.NikiforovFA.Sprint5.Task0.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint5.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по     *");
            Console.WriteLine("* формуле и записывает его в файл                                         *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("* Файл: " + res);
            Console.WriteLine("* Создан!");
        }
    }
}
