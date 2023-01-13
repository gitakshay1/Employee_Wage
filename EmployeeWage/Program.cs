using EmployeeWage;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyWage("Tata", 14, 24, 104);
            empWageBuilder.addCompanyWage("Mhaindra", 18, 25, 108);
            empWageBuilder.ComputeEmpWage();
        }
    }
}
