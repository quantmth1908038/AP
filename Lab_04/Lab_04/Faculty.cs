using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_04
{
    class Faculty : Employee
    {
        protected DateTime officeHours;
        protected string rank;

        public Faculty(DateTime officeHours, string rank, string department, double salary, DateTime dateHired, string name, string phone, string email) : base(department,salary,dateHired,name,phone,email)
        {
            this.officeHours = officeHours;
            this.rank = rank;
        }

        public DateTime POfficeHours
        {
            get { return officeHours; }
            set { officeHours = value; }
        }
        public string PRank
        {
            get { return rank; }
            set { rank = value; }
        }

        public override double CalculateBonus()
        {
            return 1000 + salary * 0.05;
        }

        public override string CalculateVacation()
        {
            TimeSpan t = DateTime.Now - base.PDateHired;
            if(t.Days > 1068)
            {
                if(rank == "Senior Lecturer")
                {
                    return "6 Weeks";
                }
                else
                {
                    return "5 Weeks";
                }
            }
            else
            {
                return "4 Weeks";
            }
        }

        public override string ToString()
        {
            return "Faculty: \n" +
                base.ToString();
        }



    }
}
