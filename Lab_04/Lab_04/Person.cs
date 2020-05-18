using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_04
{
    class Person
    {
        protected string name;
        protected string phone;
        protected string email;

        public Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public string PName
        {
            get { return name; }
            set { name = value; }
        }

        public string PPhone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string PEmail
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + "\n"
                + "Email Address: " + email;
        }
    }
}
