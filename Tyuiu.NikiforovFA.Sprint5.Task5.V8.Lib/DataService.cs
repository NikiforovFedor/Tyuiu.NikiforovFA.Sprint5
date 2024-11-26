﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NikiforovFA.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".",",");
                    res = Math.Min(Convert.ToDouble(line), res);
                }
            }
            return res;
        }
    }
}