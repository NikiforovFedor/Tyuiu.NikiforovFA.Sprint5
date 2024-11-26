﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.NikiforovFA.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double res = Math.Round((Math.Sin(Math.Pow(Convert.ToDouble(strX), 3))) + (2 / (Convert.ToDouble(strX))), 3);
            return res;
        }
    }
}
