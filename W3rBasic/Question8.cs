using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3rBasic
{
    class Question8
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine("Expected Output:");

            MultTable(x);
        }

        static void MultTable(int num)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }

        }
    }
}
