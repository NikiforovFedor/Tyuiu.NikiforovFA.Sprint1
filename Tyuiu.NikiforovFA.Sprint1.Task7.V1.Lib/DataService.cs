﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            return Math.Round((b + Math.Sqrt((b * b) + 4 * a * c))/(2 * a) - Math.Pow(a,3)*c + Math.Pow(b,-2),3);
        }
    }
}
