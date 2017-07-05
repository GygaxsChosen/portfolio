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
                    Console.ReadKey();
                }

            }
            }
        }
    }

