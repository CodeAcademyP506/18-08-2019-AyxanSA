using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel
{
   public class Otaq
    {
        public int count;
        public decimal price;
        public string info;
    }
    public class tekOtaq:Otaq
    {
        public string TOtaq()
        {
            count = 1;
            price = 20;
            info = "cay, kofe, televizor, wifi, nahar";

            return "Otaq Sayi " + count + "\n" +
                "Qiymet " + price + "\n" +
                "Xidmetler " + info;
        }
        public string cOtaq()
        {
            count = 2;
            price = 50;
            info = "cay, kofe, televizor, wifi, 3 defe yemek";

            return "Otaq Sayi " + count + "\n" +
                "Qiymet " + price + "\n" +
                "Xidmetler " + info;
        }
        public string ucOtaq()
        {
            count = 3;
            price = 100;
            info = "cay, kofe, televizor, icki, wifi, nahar";

            return "Otaq Sayi " + count + "\n" +
                "Qiymet " + price + "\n" +
                "Xidmetler " + info;
        }
    }
}

