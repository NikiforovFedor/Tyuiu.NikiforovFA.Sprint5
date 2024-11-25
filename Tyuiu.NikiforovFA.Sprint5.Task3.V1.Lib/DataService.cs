using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            double res = (x * x * x - 8) / (2 * x * x);
            res = Math.Round(res);
            string str = res.ToString();
            
            File.Delete("OutPutFileTask3.txt");
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.txt" });
            File.AppendAllText(s, str);
            return s;
        }
    }
}
