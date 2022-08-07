using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagDay9
{
    internal class Wages
    {
        static int day_hr;
        static int WaPhr = 20;
        public int rndm()               //for geting a random number
        {
            Random ran = new Random();
            return (ran.Next(0, 2));               //randomly checking present or absent
        }
        public static int wage()                //for calculating the daily wage through switch case
        {
            int ch = new Random().Next(0, 3);

            day_hr = 0;
            switch (ch)
            {
                case 1:
                    day_hr = 4;
                    Console.WriteLine("Employee is working Part Time");
                    break;
                case 2:
                    day_hr = 8;
                    Console.WriteLine("Employee is working Full Time");
                    break;
                default:
                    day_hr = 0;
                    Console.WriteLine("Absent");
                    break;
            }
            return (WaPhr * day_hr);
        }
        public static void compute()                //for calculating the monthly wage 
        {
            int days = 0;
            int totHrs = 0;                     //total hrs present or absent
            int ToMonWag = 0;                  //total Monthly working wage
            while (days < 20 && totHrs < 100)    //loop for checking no. of hrs<101 and total daysless than 21
            {
                ToMonWag = ToMonWag + (Wages.wage());
                days++;
                totHrs = totHrs + day_hr;
                Console.WriteLine("days=" + days + " total hrs= " + totHrs + " Total wage till now = " + ToMonWag);
                if (totHrs > 100)                           //If day <20 &is a full time employee(8 hrs) & till now hrs =96 then after this total hrs=104
                {
                    ToMonWag = ToMonWag - ((totHrs - 100) * WaPhr);
                }
            }
            Console.WriteLine("Total wage of the employee for the month is = Rs." + ToMonWag);  //total monthly wage of the employee
        }
    }
}
