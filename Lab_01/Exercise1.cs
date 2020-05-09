using System;

namespace Exercise1
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            string name, address, phone;
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Phone: ");
            phone = Console.ReadLine();

            Console.WriteLine("Name: {0}\nAddress: {1}\nPhone: {2}", name,address,phone);
        }
    }
}
