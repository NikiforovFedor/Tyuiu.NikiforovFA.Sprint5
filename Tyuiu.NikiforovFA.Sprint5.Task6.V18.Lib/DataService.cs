using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string s = "0123456789";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 2; i++)
                    {
                        string l0 = line[i].ToString();
                        string l = line[i+1].ToString();
                        string l1 = line[i+2].ToString();
                        if (i == 0) 
                        {
                            if ((s.Contains(l0)) & !(s.Contains(l)))
                            {
                                res++;
                            }
                        }
                        if (!(s.Contains(l0)) & s.Contains(l) & !(s.Contains(l1)))
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
