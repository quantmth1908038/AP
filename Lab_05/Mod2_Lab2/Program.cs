﻿using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Winter");

            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
