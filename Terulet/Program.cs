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


            do
            {
                Console.Write("Kérem az A oldal értékét (0> kell lennie): ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a<=0);


            do
            {
                Console.Write("Kérem az B oldal értékét (0> kell lennie): ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b<=0);



            t = a * b;

            Console.WriteLine($"A téglalap területe: {t}");
        }
        static void Main(string[] args)
        {
            terulet();
        }
    }
}
