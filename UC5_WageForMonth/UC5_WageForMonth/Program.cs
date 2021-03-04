using System;

namespace UC5_WageForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int NUMBER_OF_WORKING_DAYS = 20;
            //variables
            int empHrs = 0;
            int empWagePerDay = 0;
            int empWagePerMonth = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else if (empCheck == IS_PART_TIME)
                empHrs = 4;
            empWagePerMonth = empHrs * EMP_RATE_PER_HOUR * NUMBER_OF_WORKING_DAYS;
            empWagePerDay = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp wage per month: " + empWagePerMonth);
            Console.WriteLine("Emp wage per day: " + empWagePerDay);
            Console.ReadKey();
        }
    }
}
