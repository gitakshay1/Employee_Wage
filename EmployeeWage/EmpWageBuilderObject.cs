using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilderArray
    {
        
        public const int Is_Full_Time = 1, Is_Part_Time = 2;
       
        private int numOfCompany=0;
        private CmpanyEmpWage[] cmpanyEmpWagesArray;
        public EmpWageBuilderArray()
        {
           this.cmpanyEmpWagesArray = new CmpanyEmpWage[5];
        }
        public void addCompanyWage(string Company, int Wage_perHour, int Working_Days, int Max_Hours_InMonth)
        {
            cmpanyEmpWagesArray[this.numOfCompany] = new CmpanyEmpWage(Company, Wage_perHour, Working_Days, Max_Hours_InMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for(int i=0; i<numOfCompany; i++)
            {
                cmpanyEmpWagesArray[i].setTotalEmpWage(this.ComputeEmpWage(this.cmpanyEmpWagesArray[i]));
                Console.WriteLine(this.cmpanyEmpWagesArray[i].ToString());
            }
        }
        public int ComputeEmpWage(CmpanyEmpWage cmpanyEmpWage)
        {
            int Employee_Hour = 0, totalWorkingDays = 0,
                 Total_Emp_Hour = 0;
            Random Randm = new Random();
            while (Total_Emp_Hour <=  cmpanyEmpWage.Max_Hours_InMonth && totalWorkingDays < cmpanyEmpWage.Working_Days)
            {
                totalWorkingDays++;
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
                Console.WriteLine("Working Days #" + totalWorkingDays + " Employee Hours are " + Employee_Hour);
            }
            return Total_Emp_Hour * cmpanyEmpWage.Wage_perHour;

        }
        
    }
}
