using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P9
{
    
    class Program
    {
        const double PI= 3.141;
        /*class Calculate
        {
            public double Calcul(ref double number)
            {
                return Math.Round(number, 3);
            }
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("How many test cases? ");
            int T = int.Parse(Console.ReadLine());
            for(int i=1;i<=T;i++)
            {
                double volume=0;
                Console.Write("ch= ");
                int ch = int.Parse(Console.ReadLine());
                if (ch > 4 || ch < 1) throw new IndexOutOfRangeException();
                else
                {
                    switch (ch)
                    {
                        case 1:
                            {
                                double a = double.Parse(Console.ReadLine());
                                if (a < 0 || a > 400)
                                    throw new FormatException();
                                else
                                {
                                    volume = a * a * a;

                                    break;
                                }
                            }
                        case 2:
                            {
                                double l = double.Parse(Console.ReadLine());
                                double b = double.Parse(Console.ReadLine());
                                double h = double.Parse(Console.ReadLine());
                               
                                if (l < 0 || h < 0 || b < 0 || l > 400 || h > 400 || b > 400)
                                    throw new FormatException();
                                else
                                    volume = l * b * h;
                                break;
                            }
                        case 3:
                            {
                                double r = double.Parse(Console.ReadLine());
                                if (r < 0 || r > 400)
                                    throw new FormatException();
                                else
                                {
                                    
                                    volume = (2.0/3.0)* PI * r;
                                    Console.WriteLine(volume);
                                }
                                break;
                            }
                        case 4:
                            {
                                double r = double.Parse(Console.ReadLine());
                                double h = double.Parse(Console.ReadLine());
                                if (r < 0 || r > 400 || h < 0 || h > 400)
                                    throw new FormatException();
                                volume = PI * r * r * h;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Nu stiu sa calculez.");
                                break;
                            }
                    }
                    volume = Math.Round(volume, 3);
                    Console.WriteLine("Volume= " + volume);

                }
            }
        }
    }
}
