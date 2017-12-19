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
            string hoursWorked;
            string payRate;
            Console.WriteLine("How many hours did you work last week?");
            hoursWorked = Console.ReadLine();
            Console.WriteLine("What is your pay rate?");
            payRate = Console.ReadLine();
            float hours = float.Parse(hoursWorked);
            float rate = float.Parse(payRate);
            float pay = hours * rate;

            Console.WriteLine("Your pay is {0}.", pay);
            Console.ReadKey();
        }
    }
}

