using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3rBasic
{
    class Question5
    {
        public static void Main(string[] args)
        {

            Console.Write("Input the First Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int temp = x;
            x = y;
            y = temp;            

            Console.WriteLine("Expected Output:");
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: {0}", x);
            Console.WriteLine("Second Number: {0}", y);        
        }
    }
}
