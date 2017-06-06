using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            temp=GetInput();
            if (temp == "y")
            {
                NameGEN();
            }
        }

        public static string GetInput ()
       {
            Console.WriteLine("Would you like to generate a name? (y/n)");
            return Console.ReadLine();
       }
        public static void NameGEN()
        { 
            char[] Vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] Consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 't', 's', 'v', 'w', 'x', 'z' };
            Random rnd = new Random();
            Console.WriteLine("Your Name is:");
            Console.Write(Consonants[rnd.Next(0,Consonants.Length)]);
            Console.Write(Vowels[rnd.Next(0,Vowels.Length)]);
            Console.Write(Consonants[rnd.Next(0,Consonants.Length)]);
            Console.Write(Consonants[rnd.Next(0,Consonants.Length)]);
            Console.Write(Vowels[rnd.Next(0,Vowels.Length)]);
            Console.Read();
        }
    }
}
