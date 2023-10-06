using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Poblacion_2031_2040 = 0;
            double Totalpoblacion = 0;
            double e = 2.71828183;
            Console.WriteLine("     Año       Población en Miles de Millones");
            for (int año = 2020; año <= 2050; año++) 
            {
                int t = año - 2000;
                double poblacion = 6.0 * Math.Pow(e,0.02 * t);
                Console.WriteLine($"    {año}         {poblacion:f5}");
                Totalpoblacion += poblacion;
                if (año >= 2031 && año>= 2040)
                {
                    Poblacion_2031_2040 += poblacion;
                }
            }
            Console.WriteLine($"La suma total de la población entre 2020 al 2050 es {Math.Round(Totalpoblacion)}");
            double Promedio_2031_2040 = Poblacion_2031_2040 / 9;
            Console.WriteLine($"El promedio de la población entre 2031 al 2040 es {Math.Round(Promedio_2031_2040)}");
            Console.ReadKey();
        }
    }
}
