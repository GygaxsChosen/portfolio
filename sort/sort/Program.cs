using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int temp;
            temp=Prompt("How many random numbers would you like to generate ? ");
           int[] Num= GenNum(temp);
            BubbleSort(Num);
            Console.ReadLine();



        }

        public static int[] GenNum(int A)
        {
            int[] RanNum = new int[(A)];
            Random random = new Random();

            for (int x = 0; x < A; x++)
            {
                int Num = random.Next(0, 100);
                RanNum[x] = Num;
                
                
            }
            return RanNum;
            
        }

        public static int Prompt(string a)
        {
            Console.WriteLine(a);
            int temp;
            temp = int.Parse(Console.ReadLine());

            return temp;


        }
        public static void MergeSort(int[] A) // WIP
        {
            if (A.Length % 2 == 0)
            {
                for (int x = 0; x < A.Length; x++)
                {

                }
            }
        }

        public static void BubbleSort(int[] A)
{
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 1;

            while (count != 0)
            {
                count = 0;
            for (int x = 0; x < (A.Length-1); x++)
            {

                
                if (A[x] > A[x + 1])
                {
                    int temp;
                    count++;
                    temp = A[x + 1];
                    A[x + 1] = A[x];
                    A[x] = temp;
                        


                }
            }

        }
            foreach(int x in A)
            {
                Console.Write(x);
                Console.Write(" ");
            }

            stopwatch.Stop();
         

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopwatch.Elapsed);
}
    }
}
