﻿using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
               
            }

            else

            {
                Console.WriteLine("Employee is Absent");
                Console.ReadKey();

            }

        }
    }
}