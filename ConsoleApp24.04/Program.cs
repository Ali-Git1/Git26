using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitab kitab = new Kitab();
            Console.WriteLine("Kitab qiymeti"+kitab.ehtiyyatmiqdar);
            Console.WriteLine("Kitab miqdari"+kitab.bookprice);


            Electron electron = new Electron();
            Console.WriteLine("Electron qiymeti" + electron.ehtiyyatmiqdar);
            Console.WriteLine("Electron miqdar" + electron.electronprice);

            Mehsul[] mehsul = {kitab,electron};

            foreach (var item in mehsul)
            {
                item.GetPrice();
               item.ReduStock(3);
            }

        }
    }
}
