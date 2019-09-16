using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
   
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Test 1");
            Identifiable test = new Identifiable(new List<string> { "bob", "fred" });

            if (test.AreYou("bob"))
            {
                Console.WriteLine("Passed Test 1");
            }

            Console.WriteLine("Test 2");

            if (!test.AreYou("omg"))
            {
                Console.WriteLine("Passed Test 2");
            }

            Console.WriteLine("Test 3");

            if (test.AreYou("BOB"))
            {
                Console.WriteLine("Passed Test 3");
            }

            Console.WriteLine("Test 4");

            if (test.FirstId == "bob")
            {
                Console.WriteLine("Passed Test 4");
            }

            Console.WriteLine("Test 5");

            test.AddIdentifier("wilma");

            if (test.AreYou("wilma"))
            {
                Console.WriteLine("Passed Test 5");
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
