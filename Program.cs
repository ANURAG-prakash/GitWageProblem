using System;

public class EmpWageBuilderArray
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    private int numofcompany = 0;
    private CompanyEmpWage[] companyEmpWageArray;
    public EmpWageBuilderArray()
    {
        this.companyEmpWageArray = new CompanyEmpWage[5];
    }
    public void addCompanyEmpWage(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
    {
        companyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, empRatePerHrs, numOfWorkingDays, maxHrsPerMonth);
        numofcompany++;
    }
    public void computerEmpWage()
    {
        for (int i = 0; i < numofcompany; i++)
        {
            companyEmpWageArray[i].setTotalEmpWage(this.computerEmpWage(this.companyEmpWageArray[i]));
            Console.WriteLine(this.companyEmpWageArray[i].toString());
        }
    }
    public class CompanyEmpWage
    {
        private string company;
        private int empRatePerHrs;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public int ComputerEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            return totalEmpWage * CompanyEmpWage.empRatePerHrs;


        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total Emp Wage For Company : " + this.company + "is : " + this.totalEmpWage;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addComapnyEmpWage(("DMart", 20, 2, 10));
            empWageBuilder.addComapnyEmpWage(("Reliance", 10, 4, 20));
            EmpWageBuilderArray.computerEmpWage();
        }
    }
}
