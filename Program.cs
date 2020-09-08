using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto uno = new Auto();

            Console.WriteLine(uno.Acelera());
            uno.Choca();
            Console.WriteLine(uno.Acelera());

        }
    }
}
