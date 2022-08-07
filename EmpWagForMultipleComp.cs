using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWDay9
{
        public interface EmpWagForMultipleComp
        {
            public int rndm();
            public int wage();
            public void compute(String company, int WaPhr, int max_workDays, int max_workHrs);
        }


        internal class Wages : EmpWagForMultipleComp
        {
            static int day_hr;
            static int WaPhr = 20;
            public int rndm()               //for geting a random number
            {
                Random ran = new Random();
                return (ran.Next(0, 2));               //randomly checking present or absent
            }
            public int wage()                //for calculating the daily wage through switch case
            {
                int ch = new Random().Next(0, 3);
                day_hr = 0;
                switch (ch)
                {
                    case 1:
                        day_hr = 4;
                        // Console.WriteLine("Employee is working Part Time");
                        break;
                    case 2:
                        day_hr = 8;
                        // Console.WriteLine("Employee is working Full Time");
                        break;
                    default:
                        day_hr = 0;
                        // Console.WriteLine("Absent");
                        break;
                }
                return (WaPhr * day_hr);
            }
            public void compute(String company, int WaPhr, int max_workDays, int max_workHrs)                //for calculating the monthly wage for each company
            {
                Console.WriteLine(company);
                int days = 0;
                int totHrs = 0;                     //total hrs present or absent
                int ToMonWag = 0;                  //total Monthly working wage
                while (days < max_workDays && totHrs < max_workHrs)
                {
                    Wages obj = new Wages();
                    ToMonWag = ToMonWag + (obj.wage());
                    days++;
                    totHrs = totHrs + day_hr;
                    // Console.WriteLine("days=" + days + " total hrs= " + totHrs + " Total wage till now = " + ToMonWag);
                    if (totHrs > max_workHrs)                           //If day <20 &  total hrs > max_workHrs
                    {
                        ToMonWag = ToMonWag - ((totHrs - max_workHrs) * WaPhr);
                    }
                }
                Console.WriteLine("Total wage of the employee for the month is = Rs." + ToMonWag);  //total monthly wage of the employee
            }
        }
}
