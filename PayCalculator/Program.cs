using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PayCalculator payCalc = new PayCalculator();

            payCalc.RunPayCalculator();

            Console.ReadKey();
        }
    }
}

