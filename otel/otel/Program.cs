using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel
{
    class Program
    {
        static void Main(string[] args)
        {
            Exselsior otels = new Exselsior();
            Console.WriteLine(otels.AOtel());
            Console.WriteLine("=================================================");
            Meredian mOtel = new Meredian();
            Console.WriteLine(mOtel.EOtel());
            tekOtaq otaq = new tekOtaq();
            Console.WriteLine("=================================================");
            Console.WriteLine("1 otel secin");

            int a = int.Parse(Console.ReadLine());

            if(a == 1)
            {
                Console.WriteLine(otaq.TOtaq());
            }
            else if(a == 2)
            {
                Console.WriteLine(otaq.cOtaq());
            }

            else if (a == 3)
            {
                Console.WriteLine(otaq.ucOtaq());
            }
            else
            {
                Console.WriteLine("bele secim movcud deyil");
            }
        }
    }
}
