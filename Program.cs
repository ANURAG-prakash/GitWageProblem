using System;
    public class EmpWageBuilder: IComputerEmpWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    private LinkedList<CompanyEmpWage> companyEmpWagelist;
    private Dictionary<string, CompanyEmpWage> companytoEmpWageMap;
    public EmpWageBuilder()
    {
        this.companyEmpWagelist = new LinkedList<CompanyEmpWage>();
        this.companytoEmpWageMap = new Dictionary<string, CompanyEmpWage>();
    }
    public void addCompanyEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
    {
        CompanyEmpWage companyEmpWage = new companyEmpWagelist(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
        this.companyEmpWagelist.AddLast(companyEmpWage);
        this.companytoEmpWageMap.add(company, companyEmpWage);
    }
    public void computerEmpWage()
    {
        foreach(CompanyEmpWage companyEmpWage in this.companyEmpWagelist)
        {
            companyEmpWage.setTotalEmpWage(this.computerEmpWage(companyEmpWage));
            Console.WriteLine(companyEmpWage.toString());
        }
    }
    private int computerEmpWage(CompanyEmpWage companyEmpWage)
        public int getTotalWage(string company)
    {
        return this.companytoEmpWageMap[company].totalEmpWage;
    }
}
class program
{
    static void Main(string[] args)
    {
        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
        empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
        empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
        empWageBuilder.computerEmpWage();
        Console.WriteLine(empWageBuilder.getTotalWage);
    }
}
public interface IComputerEmpWage
{
    public void addCompanyEmpWage(string company, int empRateHour, int numOfWorking);
    public void computerEmpWage();
    public int getTotalWage(string company);
}
public class CompanyEmpWage
{
    public string company;
    public int empRatePerHour;
    public int numOfWorkingDays;
    public int maxHoursPerMonth;
    public int totalEmpWage;
}
public CompanyEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
{
    this.company = company;
    this.empRatePerHour = empRatePerHour;
    this.numOfWorkingDays = numOfWorkingDays;
    this.maxHoursPerMonth = maxHoursPerMonth;
    this.totalEmpWage = 0;
}
public void setTotalEmpWage(int totalEmpWage)
{
    this.totalEmpWage = totalEmpWage;
}

public string tostring()
{
    return "total empn wage for company : " + this.company + "is : " + this.totalEmpWage;
}
}