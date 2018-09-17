using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;

            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        static void WorkWithLoops()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World, the counter is {counter}");
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World, the counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World, the index is {index}");
            }
        }

        static void Main(string[] args)
        {
            //ExploreIf();

            WorkWithLoops();

            Console.Read();
        }
    }
}
