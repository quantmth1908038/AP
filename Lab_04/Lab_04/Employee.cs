using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_04
{
    abstract class Employee : Person
    {
        protected string department;
        protected double salary;
        protected DateTime dateHired;

        public Employee(string department, double salary, DateTime dateHired, string name, string phone, string email) : base(name,phone,email)
        {
            this.department = department;
            this.salary = salary;
            this.dateHired = dateHired;
        }
        public string PDepartment
        {
            get { return department; }
            set { department = value; }
        }
        
        public double PSalary
        {
            get { return salary; }
            set { salary = value; }
        }
        
        public DateTime PDateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }

        public override string ToString()
        {
            return "Employee: \n" +
                base.ToString();
        }

        public abstract double CalculateBonus();

        public abstract string CalculateVacation();
    }
}
