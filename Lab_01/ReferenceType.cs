using System;

namespace ReferenceType
{
    class ReferenceType
    {
        public int valueVal;
    }
    class TestReference
    {
        static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }
        static void Main(string[] args)
        {
            ReferenceType refer = new ReferenceType();
            Test(refer);
            Console.WriteLine("The value of the variable is {0}", refer.valueVal);
            Console.ReadLine();
        }
    }
}
