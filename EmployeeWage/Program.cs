namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1,Is_Part_Time=2, Employee_Hour = 0, Wage_perHour = 20, Employee_Wage = 0;
            Random Randm= new Random();
            int empCheck= Randm.Next(0, 3);
            if(empCheck==Is_Full_Time)
            {
                Console.WriteLine("Employee is Present Full Time");
                Employee_Hour = 8;
            }
            else if(empCheck==Is_Part_Time)
            {
                Console.WriteLine("Employee is Present Part time");
                Employee_Hour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Employee_Hour = 0;
            }
            Employee_Wage = Employee_Hour * Wage_perHour;
            Console.WriteLine("Employee Wage is " + Employee_Wage);
        }
    }
}
