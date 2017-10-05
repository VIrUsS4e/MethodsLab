using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static double MathPower(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number, power));
        }
    }
}
