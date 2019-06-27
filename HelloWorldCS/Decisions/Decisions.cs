using System;

namespace Decisions
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            //local varable definition
            int a = 10;

            //check boolean condition using if statement
            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            Console.WriteLine("value of a is : {0}", a);
            Console.ReadKey();
        }
    }
}
