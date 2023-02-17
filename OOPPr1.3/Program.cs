using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPr1._3
{
    internal class Program
    {
        static void FindAverage(int a, int b, int c)
        {
            Console.WriteLine("Average: " + (((a+b+c)/3).ToString()));
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first argument");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second argument");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third argument");
            c = Convert.ToInt32(Console.ReadLine());

            FindAverage(a, b, c);
        }
    }
}
