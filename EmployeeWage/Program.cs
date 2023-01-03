namespace Employee_Wage
{
    internal class Program
    {
        public const int Is_Full_Time = 1, Is_Part_Time = 2;
        static void Main(string[] args)
        {
            int Employee_Hour = 0, Wage_perHour = 20, Daily_Employee_Wage = 0,Monthly_EmpWage=0,Working_Days=20;
            Random Randm= new Random();
            for(int day=1;day<=Working_Days; day++)
            {
                int empCheck = Randm.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Employee is Present Full Time");
                        Employee_Hour = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Employee is Present Part time");
                        Employee_Hour = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        Employee_Hour = 0;
                        break;

                }
                Daily_Employee_Wage = Employee_Hour * Wage_perHour;
                Console.WriteLine("Daily Employee Wage is " + Daily_Employee_Wage);
                Monthly_EmpWage=Monthly_EmpWage+Daily_Employee_Wage;  
            }
            Console.WriteLine("\nMonthly Employee Wage is " + Monthly_EmpWage);
        }
    }
}
