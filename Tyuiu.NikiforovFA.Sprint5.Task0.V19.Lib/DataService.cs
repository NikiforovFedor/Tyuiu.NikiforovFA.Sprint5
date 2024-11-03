using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NikiforovFA.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            double r = Math.Round((2 * x * x - 1) / (Math.Sqrt(x * x - 2)), 3);
            string s = Path.Combine($@"{Directory.GetCurrentDirectory()}", $@"\OnePutFileTask0.txt");
            File.WriteAllText(s, Convert.ToString(r));
            return s;
        }
    }
}
