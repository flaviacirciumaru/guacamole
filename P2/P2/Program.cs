using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Arithmetic
    {
       public  int add(int a, int b)
        {
            return a + b;
        }
    }
    class Adder: Arithmetic
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder c = new Adder();
            Console.WriteLine("My superclass is:" + c.GetType().BaseType.Name);
            Console.WriteLine(c.add(10, 32)+ " "+c.add(10,3)+" " + c.add(10,10));
            Console.ReadLine();
        }
    }
}
