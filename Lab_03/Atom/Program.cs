using System;
using System.Collections.Generic;
using System.Text;

namespace Atom
{
    class Program 
    {
        static void Main(string[] args)
        {
            Atom atom = new Atom();
            Console.WriteLine("Atomic Information\n================== ");
            while (atom.Accept() == true)
            {
            }
            Console.WriteLine("------------------------------------ ");
            atom.display();
        }
    }
}
