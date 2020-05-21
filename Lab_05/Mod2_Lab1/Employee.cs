using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;


        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public String getName()
        {
            return this.Name;
        }

        public int getEmployeeID()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return this.ID + " " + this.Name +" ";
        }

        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public double BaseSalary
        {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }

        public int ID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public virtual String employeeStatus()
        {
            return ToString() + "is in the company's system";
        }

    }
}
