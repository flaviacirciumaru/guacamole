using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Sports
    {
        virtual public String getName()
        {
            return "Generic Sports";
        }
        
        virtual public void getNumberOfTeamMemebers()
        {
            Console.WriteLine("Each team has n players in" + getName());
        }
    }
    class Soccer:Sports
    {
        public override string getName()
        {
            return "Soccer Class";
        }

        public override void getNumberOfTeamMemebers()
        {
            Console.WriteLine("Each team has 11 players in" + getName());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sports c1 = new Sports();
            Soccer c2 = new Soccer();
            Console.WriteLine(c1.getName());
            c1.getNumberOfTeamMemebers();
            Console.WriteLine(c2.getName());
            c2.getNumberOfTeamMemebers();
            Console.ReadLine();

        }
    }
}
