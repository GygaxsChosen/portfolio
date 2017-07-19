using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will generate an infinite list of prime numbers and will do so fairly quickly... Press anykey to begin");
            Console.Read();

            double start = 3;

            while (true) {
                start++;
                for (double x = 2; x <= start; x++)
                {
                    if (x != start && start / x % 1 == 0)
                    {
                        break;

                    }
                    if (x == start)
                    {
                        Console.WriteLine(start);
                    }
                    
                   
                }

            }
            }
        }
    }

