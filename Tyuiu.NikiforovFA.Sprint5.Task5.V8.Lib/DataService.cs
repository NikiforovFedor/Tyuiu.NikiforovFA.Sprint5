using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {

            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            String[] s = strX.Split(" ");
            double m = 1000;
            for (int i = 0; i < s.Length; i++)
            {
                double r = Convert.ToDouble(s[i]);
                m = Math.Min(m, r);
            }
            return m;
        }
    }
}
