using System;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 3 number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if(a < b)
            {
                max = b;
            }
            if(b < c)
            {
                max = c;
            }

            Console.WriteLine("Maximum: {0}", max);
        }
    }
}
