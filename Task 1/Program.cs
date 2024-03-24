using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            drobi umnik = new drobi(6, 3), glupec = new drobi(1, 5);
            Console.WriteLine(umnik.ToString());
            umnik += glupec;
            Console.WriteLine(umnik.ToString());
        }
    }
}
