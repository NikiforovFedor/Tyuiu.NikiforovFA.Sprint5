using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29

    {
        public string LoadDataAndSave(string path)
        {
            File.Delete("OutPutFileTask5.txt");
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Length - 2; i++)
                {
                    string l0 = line[i].ToString();
                    string l = line[i + 1].ToString();
                    string l1 = line[i + 2].ToString();
                    if (i == 0)
                    {
                        if ((s.Contains(l0)) & !(s.Contains(l)))
                        {
                            line = line.Replace(l0, "");
                            File.WriteAllText(s, line);
                        }
                    }
                    if (!(s.Contains(l0)) & s.Contains(l) & !(s.Contains(l1)))
                    {
                        line = line.Replace(l, "");
                        File.WriteAllText(s, line);
                    }
                }
            }
            return s;

        }
    }
}
