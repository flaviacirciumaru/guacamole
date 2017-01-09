using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P8
{
    class Program
    {
       static int func(ArrayList mylist)
        {
            for (int i = 0; i < mylist.Count; i++)
                if (mylist[i] is string) return i;
            return mylist.Count;
        }
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("nr de siruri= ");
            int m= int.Parse(Console.ReadLine());
            for ( int i=0;i<n;i++)
            {
                mylist[i]= int.Parse(Console.ReadLine());
            }
            mylist[n] = "###";
            for(int i=n+1;i<n+m;i++)
            {
                mylist[i] = Console.ReadLine();
            }

            for(int i= func(mylist)+1;i<n+m;i++)
            {
                Console.WriteLine(mylist[i] + " ");
            }

        }
    }
}
