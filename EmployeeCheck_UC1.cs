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
            Random random = new Random();
            int empCheck = random.Next(2);
            if(empCheck == 1)
            {
                Console.WriteLine("Employee is presrent");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
