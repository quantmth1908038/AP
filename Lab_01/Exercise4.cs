using System;

namespace Exercise4
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }


        }
    }
}
