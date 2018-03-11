using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3rBasic
{
    class Question7
    {
        public static void Main(string[] args)
        {

            Console.Write("Input the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output:");

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);

        }
    }
}
