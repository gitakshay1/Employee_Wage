using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public interface IComputeEmpWage
    {
        public void addCompanyWage(string Company, int Wage_perHour, int Working_Days, int Max_Hours_InMonth);
        public void ComputeEmpWage();
        public int getTotalWage(string Company);
    }
}
