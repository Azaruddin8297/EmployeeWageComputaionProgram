using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    internal class EmployeeCheck_UC1
    {
        public static void EmployeeCheck()
        {
            int IS_FULL_TIME = 1;
            int emprateperhr = 20;
            int IS_PART_TIME = 2;
            int emphrs = 0;
            int empwages = 0;


            Random random = new Random();
            int empCheck = random.Next(3);
            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is presrent");
                emphrs = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is a part Timer");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                emphrs = 0;
            }
            empwages = emphrs * emprateperhr;

            Console.WriteLine("Total wages of employye is " + empwages);

        }
    }
}
