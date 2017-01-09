using System;
using System.Collections;
using System.Linq;
namespace P7
{
    class Program
    {
        class Student { }
        class Rockstar { }
        class Hacker { }

        public class InstanceOFTutorial
        {
            public static String count(ArrayList myList)
            {
                int a = 0, b = 0, c = 0;
                a = 0;//myList.OfType<Student>().Count();
                b = 0; //myList.OfType<Rockstar>().Count();
                c = 0; //myList.OfType<Hacker>().Count();
                for(int i=0;i<myList.Count;i++)
                {
                    
                    if (myList[i] is Student)
                        a++;
                    if (myList[i] is Rockstar)
                        b++;
                    if (myList[i] is Hacker)
                        c++;
                }
                String net = a.ToString() + " " + b.ToString() + " " + c.ToString();
                return net;
            }
        }
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            Console.WriteLine("Cate obiecte ?");
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                if (s == "Student") mylist.Add(new Student());
                if (s == "Rockstar") mylist.Add(new Rockstar());
                if (s == "Hacker") mylist.Add(new Hacker());
            }
            Console.WriteLine(InstanceOFTutorial.count(mylist));
            Console.ReadLine();
        }
    }
}
