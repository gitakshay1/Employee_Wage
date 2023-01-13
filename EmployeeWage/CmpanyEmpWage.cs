using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CmpanyEmpWage
    {
        public string Company;
        public int Wage_perHour, Working_Days, Max_Hours_InMonth, Monthly_EmpWage;
        public CmpanyEmpWage(string Company, int Wage_perHour, int Working_Days, int Max_Hours_InMonth)
        {
            this.Company = Company;
            this.Wage_perHour = Wage_perHour;
            this.Working_Days = Working_Days;
            this.Max_Hours_InMonth = Max_Hours_InMonth;
            this.Monthly_EmpWage = 0;
           
        }
        public void setTotalEmpWage(int Monthly_EmpWage)
        {
            this.Monthly_EmpWage= Monthly_EmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.Company + " is :" + this.Monthly_EmpWage;
        }
    }
}
