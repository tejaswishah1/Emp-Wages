﻿using System;

namespace Employee_Wages
{
    class Program
    {
        static void Main(string[] args)
        {

            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //variable
            int empHrs ;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
           
            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee wage = " + empWage);
        }
    }
}
