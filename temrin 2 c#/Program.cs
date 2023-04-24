using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temrin_2_c_
{
    internal class Program
    {
        private static double test(double x , double y)
        {
            double result = (x * 0.35) + (y * 0.65);
            if (result < 10)
            {
                Console.WriteLine(" shoma pass nashodid");
            }
            else
            {
                Console.WriteLine(" shoma pass shodid");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" nomre ra vared konin ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" nomre nahai = "+ test(x, y));
        }
    }
}
