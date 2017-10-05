using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static double Conversion(double n)
        {
            return (n - 32) * 5 / 9;
        }

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            var celsius = Conversion(n);
            Console.WriteLine("{0:F2}", celsius);
        }
    }
}
