using System;
using System.Collections;
using System.Collections.Generic;

namespace Atom
{
    class Atom
    {
        int n;
        String s;
        String N;
        Double m;
        List<Atom> atoms = new List<Atom>();

        public Atom()
        {
        }

        public Atom(int n, string s, string N, Double m)
        {
            this.n = n;
            this.s = s;
            this.N = N;
            this.m = m;
        }

        public override string ToString()
        {
            return n +" "+ s + " " + N + " " + m;
        }
        public Boolean Accept()
        {
            Console.Write("Enter atomic number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter symbol: ");
            s = Console.ReadLine();
            Console.Write("Enter full name: ");
            N = Console.ReadLine();
            Console.Write("Enter atomic weight: ");
            double m = Convert.ToDouble(Console.ReadLine());
            if (n < 1 || n > 118)
            {
                Console.WriteLine("No Sym Name Weight");
                return false;
            }
            else
            {
                Atom atom = new Atom(n, s, N, m);
                atoms.Add(atom);
                return true;
            }
        }

        public void display()
        {
            foreach(Atom atom in atoms)
            {
                Console.WriteLine(atom);
            }
        }
       
    }
}
