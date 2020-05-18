using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_04
{
    class Staff : Employee
    {
        protected string title;

        public Staff(string title, string department, double salary, DateTime dateHired, string name, string phone, string email) : base(department, salary, dateHired, name, phone, email)
        {
            this.title = title;
        }

        public string PTitle
        {
            get { return title; }
            set { title = value; }
        }

        public override double CalculateBonus()
        {
            return salary * 0.06;
        }

        public override string CalculateVacation()
        {
            TimeSpan t = DateTime.Now - base.PDateHired;
            if (t.Days > 1825)
            {
                return "4 Weeks";
            }
            else
            {
                return "3 Weeks";
            }
        }
        public override string ToString()
        {
            return "Staff: \n" +
                base.ToString();
        }
    }
}
