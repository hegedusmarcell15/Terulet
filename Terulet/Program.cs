using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terulet
{
    internal class Program
    {       
        static void terulet () 
        {
            Console.WriteLine("Téglalap területének számítása.");

            int a;
            int b;
            int t;

            a =  Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            t = a*b;
        }
        static void Main(string[] args)
        {
            terulet();
        }
    }
}
