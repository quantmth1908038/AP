using System;

namespace Employee
{
    class Employee
    {
        public static int EmpId = 20;
        public static string EmpName = "James";

        static void Main(string[] args)
        {
            Console.WriteLine("Employee ID: " + EmpId);
            Console.WriteLine("Employee Name: " + EmpName);
        }

        public string Name = "Wilson";
        private float _salary;
        protected float Salary;

        internal static int NumOne = 3;


    }
}
