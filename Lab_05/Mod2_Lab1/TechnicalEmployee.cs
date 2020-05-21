using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(String name) : base(name, 7500)
        {

        }

        public override string employeeStatus()
        {
            return this.ToString() + "has" + this.successfulCheckIns + "successfull check ins" ;
        }

    }
}
