using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class EmployeeCheck_UC1
    {
      public const int IS_FULL_TIME = 1;
      
      public const int IS_PART_TIME = 2;
      public const  int emprateperhr = 20;
        public const int Maxhrs = 100;
        public const int Maxday = 20;
        public static void EmployeeCheck()
        {
            
            int emphrs = 0;
            int empwages = 0;
            int empMonthWages = 0;
          
            int MonthlyWorkingHrs = 0;
            int totalWorkingDays = 0;
            
            int totalEmpHrs = 0;
            

           while( totalEmpHrs <= Maxhrs && totalWorkingDays < Maxday )
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is presrent");
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is a part Timer");
                        emphrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        emphrs = 0;
                        break;      
                }
               
                totalEmpHrs += emphrs;
                Console.WriteLine("Day# : " + totalWorkingDays +" Emp hrs : " +emphrs);
                empwages = emphrs * emprateperhr;
                Console.WriteLine("Employee Daily wage is " + empwages);

            }
            
            empMonthWages = totalEmpHrs * emprateperhr;
            Console.WriteLine(totalEmpHrs);
            Console.WriteLine(empMonthWages);



            // Console.WriteLine("Total wages of employye is " + empwages);
            //Console.WriteLine("Total Monthly wages of employye is " + empMonthWages);
            //if (MonthlyWorkingHrs > Maxhrs)
            //{
            //   Console.WriteLine("wages for hundread hrs");
            //}

        }
    }
}
