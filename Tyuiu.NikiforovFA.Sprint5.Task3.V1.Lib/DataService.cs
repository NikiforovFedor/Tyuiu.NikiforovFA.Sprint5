using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string res = ((x * x * x - 8) / (2 * x * x)).ToString();
            
            File.Delete("OutPutFileTask3.txt");
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.txt" });
            File.AppendAllText(s, res);
            return s;
        }
    }
}
