using EmployeeWage;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyWage("Tata", 14, 24, 104);
            empWageBuilder.addCompanyWage("Mhaindra", 18, 25, 108);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage for Tata Company :" + empWageBuilder.getTotalWage("Tata"));
        }
    }
}
