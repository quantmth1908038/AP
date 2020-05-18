using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        string firstName;
        string lastName;
        string address;
        long sin;
        double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public void Salary(int percentage)
        {
            salary = salary + salary * percentage / 100;
        }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName + "\n"
                + "Address: " + address + "\n"
                + "Sin: " + sin + "\n"
                + "Salary: " + salary;
        }
    }
}
