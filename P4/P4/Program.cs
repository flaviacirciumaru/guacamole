using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        interface AdvancedArithmethic
        {
            int divisor_sum(int n);
        }
        class MyCalculator: AdvancedArithmethic
        {
           public  int divisor_sum(int n)
            {
                int i, sum = 1+n;
                for(i=2;i<=n/2;i++)
                {
                    sum += i;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            int s;
            MyCalculator my_calculator = new MyCalculator();
            Console.WriteLine("Interface Implemented: " + my_calculator.GetType().GetInterfaces());
            s=my_calculator.divisor_sum(6);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
