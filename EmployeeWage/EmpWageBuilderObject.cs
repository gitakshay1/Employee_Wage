using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        
        public const int Is_Full_Time = 1, Is_Part_Time = 2;
        private LinkedList<CmpanyEmpWage> cmpanyEmpWageList;
        private Dictionary<string, CmpanyEmpWage> cmpanyEmpWageMap;
        public EmpWageBuilder()
        {
            this.cmpanyEmpWageList = new LinkedList<CmpanyEmpWage>();
            this.cmpanyEmpWageMap = new Dictionary<string, CmpanyEmpWage>();
        }
        public void addCompanyWage(string Company, int Wage_perHour, int Working_Days, int Max_Hours_InMonth)
        {
            CmpanyEmpWage cmpanyEmpWage = new CmpanyEmpWage(Company, Wage_perHour, Working_Days, Max_Hours_InMonth);
            this.cmpanyEmpWageList.AddLast(cmpanyEmpWage);
            this.cmpanyEmpWageMap.Add(Company, cmpanyEmpWage);
        }
        public void ComputeEmpWage()
        {
            foreach(CmpanyEmpWage cmpanyEmpWage in this.cmpanyEmpWageList)
            {
                cmpanyEmpWage.setTotalEmpWage(this.ComputeEmpWage(cmpanyEmpWage));
                Console.WriteLine(cmpanyEmpWage.ToString());
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
        public int getTotalWage(string Company)
        {
            return this.cmpanyEmpWageMap[Company].Monthly_EmpWage;
        }


    }
}
