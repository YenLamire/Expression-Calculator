using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Calculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var tb = new DataTable();
                Console.Title = "Calculator - Yen Lamire";
                Console.WriteLine("Please write your equation, i.e (2*4-7+953)");
                string expression = Console.ReadLine();
                try
                {
                    Console.WriteLine("Result : " + tb.Compute(expression, null));
                    Console.ReadKey();
                }
                catch (Exception x)
                {
                    Console.WriteLine("Invalid Expression, error : " + x.ToString());
                    Console.ReadKey();
                }
            }
        }
    }
}
