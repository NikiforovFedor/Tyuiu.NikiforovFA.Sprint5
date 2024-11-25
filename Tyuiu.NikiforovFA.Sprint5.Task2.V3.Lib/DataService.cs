using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            double res;
            int rows = matrix.GetLength(0) + 1;
            int colomn = matrix.Length / rows;
            File.Delete("OutPutFileTask2.txt");
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 2 != 0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0;i < rows; i++)
            {
                for(int j = 0;j < colomn; j++)
                {
                    if (j != colomn)
                    {
                        str += matrix[i, j] + ";" ;
                    }
                    else
                    {
                        str += matrix[i,j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(s, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(s, str);
                }
                str = "";
            }
            return s;

        }
    }
}
