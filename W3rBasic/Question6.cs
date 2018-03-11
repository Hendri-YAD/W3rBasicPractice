using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3rBasic
{
    class Question6
    {
        public static void Main(string[] args)
        {

            Console.Write("Input the first number to multiply: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int result = x * y * z;

            Console.WriteLine("Expected Output: {0} x {1} x {2} = {3}",
                x, y, z, result);            
            
        }
    }
}
