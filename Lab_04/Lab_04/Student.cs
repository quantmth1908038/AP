using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_04
{
    class Student : Person
    {
        protected string program;

        public Student(string program, string name, string phone, string email) : base(name, phone, email) 
        {
            this.program = program;
        }

        public string PProgram
        {
            get { return program; }
            set { program = value; }
        }

        public override string ToString()
        {
            return "Student: \n"
                + base.ToString();
        }
    }
}
