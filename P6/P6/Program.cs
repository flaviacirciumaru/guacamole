using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6
{
    class Program
    {
        class Bicycle
        {
           virtual public String defineMe()
            {
                return " a vehicle with pedals.";
            }
        }
        class Motorcycle:Bicycle
        {
            public override string defineMe()
            {
                return " a cycle with engine.";
            }
            public Motorcycle()
            {
                Console.WriteLine("Hello I am a motorcycle, I am" + defineMe());
                string temp = base.defineMe();
                Console.WriteLine("My ancestor is a cycle who is " + temp);
            }
        }
        static void Main(string[] args)
        {
            Motorcycle M = new Motorcycle();
            Console.ReadLine();
        }
    }
}
