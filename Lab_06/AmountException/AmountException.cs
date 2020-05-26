using System;

namespace AmountException
{
    class personName
    {
        string Name;

        public void setName()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
        }
        public String getName()
        {
            return this.Name;
        }
    }

    public class InvalidSalary : ApplicationException
    {
        public InvalidSalary() : base("Enter salary greater than 60000") { }
    }
    public class InvalidBouns : ApplicationException
    {
        public InvalidBouns() : base("Enter bonus greater than 10000") { }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            int Salary = 0;
            int Bonus = 0;
            personName pN = new personName();
            pN.setName();

            try
            {
                Console.Write("Enter a salary :");
                Salary = Convert.ToInt32(Console.ReadLine()) ;
                if (Salary > 60000 || Salary < 0)
                {
                    throw new InvalidSalary();
                }
            }
            catch (InvalidSalary objInvalid)
            {
                Console.WriteLine(objInvalid.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            try
            {
                Console.Write("Enter a bonus :");
                Bonus = Convert.ToInt32(Console.ReadLine());
                if (Bonus > 10000 || Bonus < 0)
                {
                    throw new InvalidBouns();
                }
            }
            catch (InvalidBouns objInvalid)
            {
                Console.WriteLine(objInvalid.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }

            finally
            {
                if (Salary <= 60000 && Bonus >= 0)
                {
                    Console.WriteLine("-------------\n" + pN.getName()) ;
                    Console.WriteLine(Salary + "\n" + Bonus);
                }
            }
            Console.ReadLine();
        }
    }
}
