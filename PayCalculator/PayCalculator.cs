using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    /*private float CalculatePay()
    {
        string hoursWorked;
        string payRate;
        float standardWeek = 40;
        float overTimeRate = 1.5f;
        float paycheck = 0;

        Console.WriteLine("Enter hours worked this week: ");
            hoursWorked = Console.ReadLine();
        Console.WriteLine("Enter hourly rate: ");
            payRate = Console.ReadLine();
        float hours = float.Parse(hoursWorked);
        float rate = float.Parse(payRate);

        if (hours > standardWeek)
        {
            float overTimeHours = hours - standardWeek;
            float regPay = standardWeek * rate;
            float overTimePay = rate * overTimeRate * overTimeHours;
            paycheck = overTimePay + regPay;
        }
        else
        {
            paycheck = hours * rate;
        }
        Console.WriteLine("Your pay check is {0}.", paycheck);
        Console.ReadKey();
        return paycheck;

    }*/
    public class PayCalculator
    {
        private float hoursWorked;
        private float payRate;
        private float paycheck;

        private void CalculatePay()
        { 
            
        }

        public void GetUserHours()
        {
            Console.WriteLine("Enter hours worked this week: ");
            hoursWorked = float.Parse(Console.ReadLine());
        }

        public void GetUserRate()
        {
            Console.WriteLine("Enter hourly rate: ");
            payRate = float.Parse(Console.ReadLine());
        }

        public void RunPayCalculator(/*float hours, float rate*/)
        {
            float standardWeek = 40;
            float overTimeRate = 1.5f;

            GetUserHours();
            GetUserRate();

            if (hoursWorked > standardWeek)
            {
                float overTimeHours = hoursWorked - standardWeek;
                float regPay = standardWeek * payRate;
                float overTimePay = payRate * overTimeRate * overTimeHours;
                paycheck = overTimePay + regPay;
            }
            else
            {
                paycheck = hoursWorked * payRate;
            }
            DisplayPay();
        }



        public float DisplayPay()
        {
            Console.WriteLine("Your pay check is {0}.", paycheck);
            Console.ReadKey();
            return paycheck;
        }
     }
}
