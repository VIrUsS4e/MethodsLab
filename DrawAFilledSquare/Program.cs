using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void HeadFooterLines(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void MiddleRows(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
                
            }
            Console.WriteLine("-");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HeadFooterLines(n);
            for (int i = 1; i <= n - 2; i++)
            {
                MiddleRows(n);
            }
            
            HeadFooterLines(n);

        }
    }
}
