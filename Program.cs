using System;

    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computerEmpWageSecond(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("total Emp Wage for Company : " + company + "is :" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computerEmpWageSecond("DMart", 20, 2, 10);
            computerEmpWageSecond("Reliance", 10, 4, 20);
        }
    }

