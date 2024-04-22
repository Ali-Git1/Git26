using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24._04
{
    internal class Kitab : Mehsul
    {
        public int bookprice { get; set; } = 50;

        public int ehtiyyatmiqdar { get; set; } = 10;
        public void GetPrice()
        {
            Console.WriteLine(bookprice);
        }

        public void ReduStock(int redus)
        {
            Console.WriteLine(ehtiyyatmiqdar-redus);
        }
    }
}
