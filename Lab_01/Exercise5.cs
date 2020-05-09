using System;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            int n;
            double f = 1;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(n<1 || n > 20)
            {
                Console.WriteLine("Enter n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i <= n; i++)
            {
                f*= i;
            }
            Console.WriteLine("factorials of {0}: {1}", n, f);
        }
    }
}
