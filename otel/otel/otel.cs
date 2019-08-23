using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel
{
    public class otel
    {
        public string Name;
        public string Adress;
        public int minPrice;
        public string service;
    }

    public class Exselsior : otel
    {
        public string AOtel()
        {
            Name = "Exselsior";
            Adress = "M.A Sabir Street, 75, AZ5700 Şǝmkir, Azerbaijan ";
            minPrice = 30;
            service = " free transport";

            return "1. Otel " + Name + "\n" +
                "Adress " + Adress + "\n" +
                "Minimum Price " + minPrice + "\n" +
                "Servises " + service;
        }
    }
    public class Meredian : otel
    {
        public string EOtel()
        {
            Name = "Meredian";
            Adress = "Bakı-Qazax magistralının 400cu km";
            minPrice = 30;
            service = " free transport";

            return "2. Otel " + Name + "\n" +
                "Adress " + Adress + "\n" +
                "Minimum Price " + minPrice + "\n" +
                "Servises " + service;
        }
    }
}
