using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        abstract class Book
        {
            public string title;
            public abstract void setTitle(string s);
            public String getTitle()
            {
                return title;
            }
        }
        class MyBook: Book
        {
            override public void setTitle(string s)
            {
                title = s;
            }
        }
        static void Main(string[] args)
        {
            MyBook new_novel = new MyBook();
            new_novel.setTitle("A tale of 2 cities");
            Console.WriteLine(new_novel.getTitle());
            Console.ReadLine();
        }
    }
}
