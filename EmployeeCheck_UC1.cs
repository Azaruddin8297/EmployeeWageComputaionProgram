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
            switch (empCheck) {
                case 0:
                    Console.WriteLine("Employee is presrent");
                    emphrs = 8;
                    break;
                case 1:
                    Console.WriteLine("Employee is a part Timer");
                    emphrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    emphrs = 0;
                    break;
            }
            empwages = emphrs * emprateperhr;

            Console.WriteLine("Total wages of employye is " + empwages);

        }
    }
}
