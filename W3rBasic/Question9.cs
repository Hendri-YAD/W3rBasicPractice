using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3rBasic
{
    class Question9
    {
        
        public static void Main(string[] args)
        {

            Console.Write("Enter the First number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output:");

            Average(number1, number2, number3, number4);            
        }

        static void Average(int a, int b, int c, int d)
        {
            int avg = (a + b + c + d) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is : {4}",
                a, b, c, d, avg);
        }
        
    }
}
