using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class CmpanyEmpWage
    {
        private string Company;
        private int Wage_perHour, Working_Days, Max_Hours_InMonth, Monthly_EmpWage;
        public CmpanyEmpWage(string company, int wage_perHour, int working_Days, int max_Hours_InMonth)
        {
            this.Company = company;
            this.Wage_perHour = wage_perHour;
            this.Working_Days = working_Days;
            this.Max_Hours_InMonth = max_Hours_InMonth;
           
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
