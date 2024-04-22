using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24._04
{
    internal class Electron : Mehsul
    {
        public int electronprice { get; set; } = 20;

        public int ehtiyyatmiqdar { get; set; } = 4;
        public void GetPrice()
        {
            Console.WriteLine(electronprice);
        }

        public void ReduStock(int redus)
        {
            Console.WriteLine(ehtiyyatmiqdar-redus);
        }

        public void ReduStock()
        {
            throw new NotImplementedException();
        }
    }
}
