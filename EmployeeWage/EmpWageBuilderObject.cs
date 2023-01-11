using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilderObject
    {
        public const int Is_Full_Time = 1, Is_Part_Time = 2;
        private string Company;
        private int Wage_perHour, Working_Days, Max_Hours_InMonth, Monthly_EmpWage;
        public EmpWageBuilderObject(string Company, int Wage_perHour, int Working_Days, int Max_Hours_InMonth)
        {
            this.Company = Company;
            this.Wage_perHour = Wage_perHour;
            this.Working_Days = Working_Days;
            this.Max_Hours_InMonth = Max_Hours_InMonth;
        }
        public void ComputionEmpWage()
        {
            int Employee_Hour = 0, Monthly_EmpWage = 0,
                day = 0, Total_Emp_Hour = 0;
            Random Randm = new Random();
            while (Total_Emp_Hour < this.Max_Hours_InMonth && day < this.Working_Days)
            {
                day++;
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
                Total_Emp_Hour +=Employee_Hour;
                Console.WriteLine("Working Days #" + day + " Employee Hours are " + Employee_Hour);
            }
            Monthly_EmpWage = this.Wage_perHour * Total_Emp_Hour;
            Console.WriteLine("\n Monthly Employee Wage for Company " + Company + " is " + Monthly_EmpWage);

        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.Company + " is :" + this.Monthly_EmpWage;
        }
    }
}
