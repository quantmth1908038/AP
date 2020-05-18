using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Quan", "Truong Minh", "Ha Noi",0,1000000);
            Console.WriteLine(employee.ToString());
            employee.Salary(5);
            Console.WriteLine(employee.ToString());

        }
    }
}
