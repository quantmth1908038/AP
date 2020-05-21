using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab2
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(String name) : base(name, 50000)
        {

        }

        public override string employeeStatus()
        {
            return ToString() + "with a budget of " + this.bonusBudget;
        }

    }
}
