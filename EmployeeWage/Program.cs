namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_Part_Time = 1;
            Random Randm= new Random();
            int empCheck= Randm.Next(0, 2);
            if(empCheck==IS_Part_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
