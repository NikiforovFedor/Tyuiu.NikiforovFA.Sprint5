﻿using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            double res = (Math.Pow(x,3) - 8) / (2 * (x * x));
            res = Math.Round(res,3);

            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;   
        }
    }
}
