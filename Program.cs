using System;

public class EmpWageBuilderObject
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    private string company;
    private int empRatePerHrs;
    private int numOfWorkingDays;
    private int maxHoursPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
    {
        this.company = company;
        this.empRatePerHrs = empRatePerHrs;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void computerEmpWage()
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
        int totalEmpWage = totalEmpHrs * empRatePerHrs;
        Console.WriteLine("total Emp Wage for Company : " + company + "is :" + totalEmpWage);
       
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
        EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
        EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
        dMart.computerEmpWage();
        Console.WriteLine(dMart.tostring());
        reliance.computerEmpWage();
        Console.WriteLine(reliance.tostring());
    }
}
