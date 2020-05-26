using System;

namespace TestProgram
{
    class TestProgram
    {
        void Count(int boys, int girls)
        {
            Console.WriteLine(boys + girls);
        }

        static void Main(string[] args)
        {
            TestProgram test = new TestProgram();
            test.Count(boys: 16, girls: 24);
        }
    }
}
