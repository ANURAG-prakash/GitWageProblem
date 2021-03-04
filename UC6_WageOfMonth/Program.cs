using System;

namespace UC6_WageOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int n;
            int full = 0, half = 0;
            Console.WriteLine("Enter the days in month");
            n = Console.Read();
            int workingHrs = 0;
            int workingDays = 0;
            int empWagePerMonth = 0;
            for (i = 1; i <= n; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == IS_FULL_TIME)
                    workingHrs = workingHrs + 8;
                else if (empCheck == IS_PART_TIME)
                    workingHrs = workingHrs + 4;
                else if (empCheck == IS_FULL_TIME || empCheck == IS_PART_TIME)
                    workingDays = workingDays + 1;
            }
            if (workingHrs >= 100)
                empWagePerMonth = workingHrs * EMP_RATE_PER_HOUR;
            else if (workingDays >= 20)
                empWagePerMonth = workingHrs * EMP_RATE_PER_HOUR ;
            Console.WriteLine("Emp wage per month: " + empWagePerMonth);

            Console.ReadKey();
        }
    }
}
