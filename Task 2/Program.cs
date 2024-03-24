using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TimeEUDecorator;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeEU timeEU = new();
            TimeUS timeUS = new();
            Console.WriteLine(timeEU.ShowTime()); 
            Console.WriteLine(timeUS.ShowTime());
            TimeEUDecorator timeEuDecorator = new TimeEUDecorator(new TimeEU(), 3, '$');
            TimeUSDecorator timeUSDecorator = new TimeUSDecorator(new TimeUS(), 5, '#');
            Console.WriteLine(timeEuDecorator.ShowTime());
            Console.WriteLine(timeUSDecorator.ShowTime());
        }
    }
}
