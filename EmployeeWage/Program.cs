using EmployeeWage;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject tata = new EmpWageBuilderObject("Tata", 14, 24, 104);
            EmpWageBuilderObject mahindra = new EmpWageBuilderObject("Mhaindra", 18, 25, 108);
            tata.ComputionEmpWage();
            Console.WriteLine(tata.ToString());
            mahindra.ComputionEmpWage();
            Console.WriteLine(mahindra.ToString());
        }
    }
}
