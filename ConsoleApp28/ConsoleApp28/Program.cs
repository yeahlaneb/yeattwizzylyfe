using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // I,U
        List<double> I = new List<double> { 2.4, 3.4, 3.7, 5.2 };
        List<double> U = new List<double> { 12.1, 6.8, 16.8, 19.4 };

        // Обчислення опорів для кожної пари I та R
        List<double> resistances = new List<double>();
        for (int i = 0; i < I.Count; i++)
        {
            double resistance = U[i] / I[i];
            resistances.Add(resistance);
        }

        // Обчислення середнього значення опорів
        double avgresistance = resistances.Average();

        Console.WriteLine("Nablizhene chislo R metodom naimenshih kvadrativ: " + avgresistance);
    }
}
