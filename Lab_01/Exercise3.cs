using System;

namespace Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number between 1 and 7: ");
            x = Convert.ToInt32(Console.ReadLine());

            while(x < 1 || x > 7)
            {
                Console.Write("Enter a number between 1 and 7: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            switch (x)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
               
            }
               
        }
    }
}
