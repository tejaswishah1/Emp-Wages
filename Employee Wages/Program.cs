using System;

namespace Employee_Wages
{
    class Program
    {
        static void Main(string[] args)
        {

            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int DAYS = 1;

            //variable
            int totalHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

          

            //Computation
           

            for (DAYS = 1; DAYS <= 20; DAYS += 1)
            {
                while (totalHrs <= 100)
                {
                    Random random = new Random();
                    int empCheck = random.Next(0, 2);
                    if (empCheck == IS_FULL_TIME)
                    {
                        empHrs = 8;
                        totalHrs += empHrs;
                    }
                    else
                    {
                        empHrs = 4;
                        totalHrs += empHrs;
                    }
                }
                empWage = totalHrs * EMP_RATE_PER_HOUR * DAYS;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Employee Wage = " + totalEmpWage);
        }
    }
}
