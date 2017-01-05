using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avocado
{
    class Program
    {
        public class Animal
        {
            public void walk()
            {
                Console.WriteLine("I am walking");
            }
        }
        public class Bird: Animal
        {
            public void fly()
            {
                Console.WriteLine("I am flying.");
            }
            public void sing()
            {
                Console.WriteLine("I am singing");
            }
        }
        static void Main(string[] args)
        {
            Bird bird = new Avocado.Program.Bird();
            bird.walk();
            bird.fly();
            bird.sing();
            Console.ReadLine();
        }
    }
}
